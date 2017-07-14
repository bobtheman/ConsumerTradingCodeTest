using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using DataStreams.Csv;
using Microsoft.VisualBasic.FileIO;
using System.Data.OleDb;

namespace ConsumerTrading
{
    public partial class ConsumerForm : Form
    {
        public ConsumerForm()
        {
            InitializeComponent();
            txterror.Visible = false;
        }

        private void LoadFromFile(string filepath,string filename)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    using (TextFieldParser csvParser = new TextFieldParser(filepath))
                    {
                        csvParser.CommentTokens = new string[] { "#" };
                        csvParser.SetDelimiters(new string[] { "," });
                        csvParser.HasFieldsEnclosedInQuotes = true;

                        // Skip the row with the column names
                        csvParser.ReadLine();

                        DateTime management_fee_date = DateTime.Parse("01/01/1990").Date;

                        DataTable dt = new DataTable { TableName = "PolicyDetails" };
                        dt.Columns.Add("policy_number");
                        dt.Columns.Add("policy_start_date");
                        dt.Columns.Add("premiums");
                        dt.Columns.Add("membership");
                        dt.Columns.Add("management_fee");
                        dt.Columns.Add("discretionary_bonus");
                        dt.Columns.Add("uplift_percentage");
                        dt.Columns.Add("policy_type");
                        dt.Columns.Add("maturity");

                        while (!csvParser.EndOfData)
                        {
                            string[] fields = csvParser.ReadFields();
                            string policy_number = fields[0];
                            DateTime policy_start_date = DateTime.Parse(fields[1]).Date;
                            double premiums = Convert.ToDouble(fields[2]);
                            string membership = fields[3];
                            double discretionary_bonus = Convert.ToDouble(fields[4]);
                            double uplift_percentage = Convert.ToDouble(fields[5]);
                            string policy_type = policy_number[0].ToString();

                            double management_fee = 0;
                            double result = 1 + (uplift_percentage / 100);
                            double uplift_percentage_value = ((uplift_percentage / 100) * 10);

                            if (policy_type == "A")
                            {
                                management_fee = Convert.ToDouble("0.03");
                            }
                            else if (policy_type == "B")
                            {
                                management_fee = Convert.ToDouble("0.05");
                            }
                            else
                            {
                                management_fee = Convert.ToDouble("0.07");
                            }

                            double maturity = (premiums - (premiums * management_fee) + discretionary_bonus) * result;

                            dt.Rows.Add(new object[] { policy_number, policy_start_date, premiums, membership, management_fee, discretionary_bonus, uplift_percentage, policy_type, Math.Round(maturity, 2) });
                        }

                        dt.WriteXml(filename);
                        StringWriter sw = new StringWriter();
                        dt.WriteXml(sw);
                        txtXml.Text = sw.ToString();
                    }
                }
                else
                {
                    txterror.Visible = true;
                    txterror.Text = "Please select a vaild file";
                }

                MessageBox.Show("XML file has been generated");
            }
            catch (Exception ex)
            {
                txterror.Visible = true;
                txterror.Text = ex.Message;
            }
        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files (*.xml)|*.xml"; //sets the file type to xml
            sfd.FileName = "MaturityData";
            string sfdname = sfd.FileName;
            if (sfd.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                LoadFromFile(txtCSV.Text, Path.GetFullPath(sfd.FileName));
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text files | *.csv"; // file types, that will be allowed to upload
                dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
                if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
                {
                    String filepath = dialog.FileName; // get name of file
                    using (StreamReader reader = new StreamReader(new FileStream(filepath, FileMode.Open)))
                    {
                        txtCSV.Text = filepath;
                    }
                }
            }
            catch (Exception ex)
            {
                txterror.Visible = true;
                txterror.Text = ex.Message;
            }
            
        }
    }
}