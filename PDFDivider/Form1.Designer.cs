using System;

namespace PDFDivider
{
    partial class Form1
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
            this.FBdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPdfHolder = new System.Windows.Forms.Button();
            this.IPDFFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExcelinput = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblDirOutput = new System.Windows.Forms.Label();
            this.btnFBoutput = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.Lbltext2 = new System.Windows.Forms.Label();
            this.Lbltext3 = new System.Windows.Forms.Label();
            this.lblPDFFolderroute = new System.Windows.Forms.Label();
            this.LblExcelFileRouter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FBdialog
            // 
            this.FBdialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest_1);
            // 
            // btnPdfHolder
            // 
            this.btnPdfHolder.Location = new System.Drawing.Point(480, 92);
            this.btnPdfHolder.Name = "btnPdfHolder";
            this.btnPdfHolder.Size = new System.Drawing.Size(96, 23);
            this.btnPdfHolder.TabIndex = 0;
            this.btnPdfHolder.Text = "PdfFolder";
            this.btnPdfHolder.UseVisualStyleBackColor = true;
            this.btnPdfHolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // IPDFFileDialog
            // 
            this.IPDFFileDialog.FileName = "IPdfFile";
            // 
            // btnExcelinput
            // 
            this.btnExcelinput.Location = new System.Drawing.Point(480, 140);
            this.btnExcelinput.Name = "btnExcelinput";
            this.btnExcelinput.Size = new System.Drawing.Size(96, 23);
            this.btnExcelinput.TabIndex = 1;
            this.btnExcelinput.Text = "Excel input";
            this.btnExcelinput.UseVisualStyleBackColor = true;
            this.btnExcelinput.Click += new System.EventHandler(this.btnExcelinput_Click_1);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(52, 342);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(524, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblDirOutput
            // 
            this.lblDirOutput.AllowDrop = true;
            this.lblDirOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDirOutput.Location = new System.Drawing.Point(52, 220);
            this.lblDirOutput.Name = "lblDirOutput";
            this.lblDirOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDirOutput.Size = new System.Drawing.Size(408, 23);
            this.lblDirOutput.TabIndex = 3;
            this.lblDirOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFBoutput
            // 
            this.btnFBoutput.Location = new System.Drawing.Point(480, 220);
            this.btnFBoutput.Name = "btnFBoutput";
            this.btnFBoutput.Size = new System.Drawing.Size(96, 23);
            this.btnFBoutput.TabIndex = 4;
            this.btnFBoutput.Text = "Output Folder";
            this.btnFBoutput.UseVisualStyleBackColor = true;
            this.btnFBoutput.Click += new System.EventHandler(this.btnFBoutput_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(49, 195);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(68, 13);
            this.lblText1.TabIndex = 5;
            this.lblText1.Text = "OutputFolder";
            // 
            // Lbltext2
            // 
            this.Lbltext2.AutoSize = true;
            this.Lbltext2.Location = new System.Drawing.Point(49, 131);
            this.Lbltext2.Name = "Lbltext2";
            this.Lbltext2.Size = new System.Drawing.Size(54, 13);
            this.Lbltext2.TabIndex = 6;
            this.Lbltext2.Text = "ExcelFiles";
            // 
            // Lbltext3
            // 
            this.Lbltext3.AutoSize = true;
            this.Lbltext3.Location = new System.Drawing.Point(49, 70);
            this.Lbltext3.Name = "Lbltext3";
            this.Lbltext3.Size = new System.Drawing.Size(57, 13);
            this.Lbltext3.TabIndex = 7;
            this.Lbltext3.Text = "PDFFolder";
            // 
            // lblPDFFolderroute
            // 
            this.lblPDFFolderroute.AllowDrop = true;
            this.lblPDFFolderroute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPDFFolderroute.Location = new System.Drawing.Point(52, 92);
            this.lblPDFFolderroute.Name = "lblPDFFolderroute";
            this.lblPDFFolderroute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPDFFolderroute.Size = new System.Drawing.Size(408, 23);
            this.lblPDFFolderroute.TabIndex = 8;
            this.lblPDFFolderroute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblExcelFileRouter
            // 
            this.LblExcelFileRouter.AllowDrop = true;
            this.LblExcelFileRouter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblExcelFileRouter.Location = new System.Drawing.Point(52, 144);
            this.LblExcelFileRouter.Name = "LblExcelFileRouter";
            this.LblExcelFileRouter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblExcelFileRouter.Size = new System.Drawing.Size(408, 23);
            this.LblExcelFileRouter.TabIndex = 9;
            this.LblExcelFileRouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.LblExcelFileRouter);
            this.Controls.Add(this.lblPDFFolderroute);
            this.Controls.Add(this.Lbltext3);
            this.Controls.Add(this.Lbltext2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnFBoutput);
            this.Controls.Add(this.lblDirOutput);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnExcelinput);
            this.Controls.Add(this.btnPdfHolder);
            this.Name = "Form1";
            this.Text = "Separador De PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FBdialog;
        private System.Windows.Forms.Button btnPdfHolder;
        private System.Windows.Forms.OpenFileDialog IPDFFileDialog;
        private System.Windows.Forms.Button btnExcelinput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFBoutput;
        public System.Windows.Forms.Label lblDirOutput;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label Lbltext2;
        private System.Windows.Forms.Label Lbltext3;
        public System.Windows.Forms.Label lblPDFFolderroute;
        public System.Windows.Forms.Label LblExcelFileRouter;
    }
}

