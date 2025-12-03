using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
    internal class PDFManager
    {
        //entrada
        public string FilePath { get; set; }
        private List<XImage> TheWholeFile = new List<XImage>();
        //rango de paginas
        public int initialPage { get; set; }
        public int finalPage { get; set; }
        //salida
        public string OutputDirectory { get; set; }

        private List<XImage> TheFinalFile = new List<XImage>();

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
        public string directoryCreate(string GeneralDirectory, string newDirectoryName)
        {

            if (!OutputDirectoryExists(GeneralDirectory))
            {
                return null;
            }
            string newDirectoryPath = $"{GeneralDirectory}/{newDirectoryName}";
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
            initialPage = initial;
            finalPage = final;
        }
        //output directory
        public bool safeoutputdirectory(string generalDirectory)
        {
            if (!OutputDirectoryExists(generalDirectory))
            {
                directoryCreate(generalDirectory, "PDFDividerOutput");
            }
            return true;
        }



    }
}
