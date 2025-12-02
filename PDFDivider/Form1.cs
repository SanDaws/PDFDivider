using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFDivider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FBdialog.ShowDialog();
            lblPDFFolderroute.Text = FBdialog.SelectedPath.ToString();

        }


        private void btnFBoutput_Click(object sender, EventArgs e)
        {
            FBdialog.ShowDialog();
            lblDirOutput.Text = FBdialog.SelectedPath.ToString();
        }

        private void btnExcelinput_Click_1(object sender, EventArgs e)
        {
            IPDFFileDialog.ShowDialog();
            LblExcelFileRouter.Text = IPDFFileDialog.FileName.ToString();
        }
    }
}
