using PDFDivider.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PDFDivider
{
    public partial class Form1 : Form
    {
        string selectedPDFFolder;
        string selectedExcelFile;
       string outputDirectory;
        private PDFManager pdfManager;
        private ExcelManager excelMng;
        private string path;
        public Form1()
        {
            InitializeComponent();
        }


        //pdf folder input
        private void button1_Click(object sender, EventArgs e)
        {
            FBdialog.ShowDialog();
            path = FBdialog.SelectedPath;
            selectedPDFFolder= path;
            lblPDFFolderroute.Text = FBdialog.SelectedPath;

        }


        private void btnFBoutput_Click(object sender, EventArgs e)
        {
            FBdialog.ShowDialog();
            path= FBdialog.SelectedPath;
            outputDirectory=path;
            lblDirOutput.Text = path;
        }

        private void btnExcelinput_Click_1(object sender, EventArgs e)
        {
            IPDFFileDialog.ShowDialog();
            path = IPDFFileDialog.FileName;
            selectedExcelFile=path;
            LblExcelFileRouter.Text = path;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            excelMng = new ExcelManager(selectedExcelFile);
            pdfManager = new PDFManager(selectedPDFFolder);
            pdfManager.SetOutputDirectory(path);
            Run.Execute(pdfManager, excelMng);

        }
    }
}
