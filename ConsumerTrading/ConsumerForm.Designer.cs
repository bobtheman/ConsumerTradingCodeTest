namespace ConsumerTrading
{
    partial class ConsumerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.txtXml = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblCSVName = new System.Windows.Forms.Label();
            this.txterror = new System.Windows.Forms.TextBox();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnupload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCSV
            // 
            this.txtCSV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCSV.Location = new System.Drawing.Point(27, 37);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(441, 20);
            this.txtCSV.TabIndex = 0;
            // 
            // txtXml
            // 
            this.txtXml.Location = new System.Drawing.Point(27, 125);
            this.txtXml.Multiline = true;
            this.txtXml.Name = "txtXml";
            this.txtXml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXml.Size = new System.Drawing.Size(522, 219);
            this.txtXml.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(24, 109);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(105, 13);
            this.lbltitle.TabIndex = 2;
            this.lbltitle.Text = "XML Output Preview";
            // 
            // lblCSVName
            // 
            this.lblCSVName.AutoSize = true;
            this.lblCSVName.Location = new System.Drawing.Point(24, 21);
            this.lblCSVName.Name = "lblCSVName";
            this.lblCSVName.Size = new System.Drawing.Size(71, 13);
            this.lblCSVName.TabIndex = 3;
            this.lblCSVName.Text = "CSV Input file";
            // 
            // txterror
            // 
            this.txterror.Location = new System.Drawing.Point(27, 350);
            this.txterror.Multiline = true;
            this.txterror.Name = "txterror";
            this.txterror.Size = new System.Drawing.Size(522, 62);
            this.txterror.TabIndex = 5;
            this.txterror.Visible = false;
            // 
            // btnExportXml
            // 
            this.btnExportXml.Location = new System.Drawing.Point(27, 72);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(522, 23);
            this.btnExportXml.TabIndex = 2;
            this.btnExportXml.Text = "Process CSV to XML";
            this.btnExportXml.UseVisualStyleBackColor = true;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnupload
            // 
            this.btnupload.Location = new System.Drawing.Point(474, 37);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(75, 20);
            this.btnupload.TabIndex = 1;
            this.btnupload.Text = "Upload CSV";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // ConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(570, 421);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.txterror);
            this.Controls.Add(this.lblCSVName);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.txtXml);
            this.Controls.Add(this.txtCSV);
            this.Name = "ConsumerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumer Trading CSV to XML";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.TextBox txtXml;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblCSVName;
        private System.Windows.Forms.TextBox txterror;
        private System.Windows.Forms.Button btnExportXml;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnupload;
    }
}

