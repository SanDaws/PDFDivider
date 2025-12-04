using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing.Printing;

namespace PDFDivider.Services
{
    internal class PDFManager
    {
        //entrada
        public string FilePath { get; set; }
        private List<XImage> WholeFile = new List<XImage>();
        //rango de paginas
        public int InitialPage { get; set; }
        public int FinalPage { get; set; }
        //salida
        public string OutputDirectory { get; set; }

        private List<XImage> FinalFile = new List<XImage>();

        //impresora
        private PrintDocument printerPDF = new PrintDocument();

        //constructor
        public PDFManager(string filePath)
        {
            FilePath = filePath;
        }
        //verificadores
        //verificar si hay ya existe el archivo pdf
        public bool IsFilePathSet()
        {
            return !string.IsNullOrEmpty(FilePath);
        }
        //verificar si el archivo es un pdf (entrada)
        public bool IsValidPdf()
        {
            // Verificar si el archivo tiene la extensión .pdf
            return FilePath.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase);
        }
        //vrificar si el archivo existe
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        //verificar si la ruta de salida existe
        public bool OutputDirectoryExists(string outputDirectory)
        {
            //true si existe, false si no
            return Directory.Exists(outputDirectory);
        }
        //crear runta de salida
        public string DirectoryCreate(string newDirectoryName)
        {

            if (!OutputDirectoryExists(OutputDirectory))
            {
                return null;
            }
            string newDirectoryPath = $"{OutputDirectory}/{newDirectoryName}";
            Directory.CreateDirectory(newDirectoryName);
            return newDirectoryPath;


        }

        //setter
        public void SetOutputDirectory(string outputDirectory)
        {
            OutputDirectory = outputDirectory;
        }
        //pagina inicial y final
        public void rangePages(int initial, int final)
        {
            InitialPage = initial;
            FinalPage = final;
        }
        //output directory
        public bool safeoutputdirectory(string generalDirectory)
        {
            if (!OutputDirectoryExists(generalDirectory))
            {
                DirectoryCreate("PDFDividerOutput");
            }
            return true;
        }



    }
}
