using PDFDivider.Properties;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Advanced;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
    public class PDFManager
    {
        //entrad
        public string folderDirectory { get; set; }
        //archivos
        public string FilePath { get; set; }
        //contenido de los archivos
        private List<PdfPage> WholeFile;
        //rango de paginas
        public int InitialPage { get; set; }
        public int FinalPage { get; set; }
        //salida
        public string OutputDirectory { get; set; }

        private List<PdfPage> FinalFile = new List<PdfPage>();


        //constructor
        public PDFManager(string folderDirectory)
        {
            //seteamos carpeta de entrada
            this.folderDirectory = folderDirectory;
            //obtenemos todos los archivos pdf en la carpeta
            
        }
        // agregar garbage colector

        //verificadores
        //vrificar si el archivo existe
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        //pagina inicial y final
        public void RangePages(int initial, int final)
        {
            InitialPage = initial;
            FinalPage = final;
        }
        //verificar si la ruta de salida existe
        public bool OutputDirectoryExists(string outputDirectory)
        {
            //true si existe, false si no
            return Directory.Exists(outputDirectory);
        }
        //crear carpeta de salida
        public string DirectoryCreate(string newDirectoryName)
        {
            Directory.CreateDirectory(newDirectoryName);
            return newDirectoryName;
        }

        //setter
        public void SetOutputDirectory(string outputDirectory)
        {
            OutputDirectory = outputDirectory;
        }
        //output directory
        public bool safeoutputdirectory(string generalDirectory)
        {
            if (!OutputDirectoryExists(generalDirectory))
            {
                DirectoryCreate(generalDirectory);
            }
            return true;
        }
        public void SetwholeFileFromInDir(int u) {
            FilePath = $@"{folderDirectory}/{u}.pdf";
        }

        /// ahora si las funciuones principales
        public void LoadPDFFile()
        {
        WholeFile = new List<PdfPage>();
            using (PdfDocument document = PdfReader.Open(FilePath, PdfDocumentOpenMode.Import))
            {
                
                foreach (PdfPage item in document.Pages)
                {
                    WholeFile.Add(item);
                }

            }
                
        }
        public void FinalFileGenerate()
        {
            FinalFile = new List<PdfPage>();
            FinalFile = WholeFile.GetRange(InitialPage - 1, FinalPage - InitialPage + 1);
        }

        public void SavePDFFile(string filePath) {
            PdfDocument output= new PdfDocument();
            foreach (PdfPage item in FinalFile)
            {
                output.AddPage(item);
            }
            output.Save(filePath);
        }

        
        //manejo de row
        public string enrutadoCarpetaFinal( int u) {
            string ruta=  $"{OutputDirectory}/{u}";
            bool res =safeoutputdirectory(ruta);
            if (res)
            {
                return ruta; 
            }
            return null;

        }

        






    }
}
