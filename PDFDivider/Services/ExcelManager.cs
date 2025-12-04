using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
        internal class ExcelManager
        {
        //private List<> TheWholeExcel;
        private string Excelpath { get; set; }
        
        public ExcelManager(string path)
            {
                Excelpath = path;
            }
        public void LoadExcel()
            {
                // Lógica para cargar el archivo de Excel
                Console.WriteLine("Cargando archivo de Excel desde: " + Excelpath);
        }
        public bool SetRoute(string path)
            {
            if (!VerifyExcelFile(Excelpath))
            {
                return false;
            }
            Excelpath = path;
            return true;



        }

        //verificar archivo excel
        public bool VerifyExcelFile(string path)
            {
                // Lógica para verificar si el archivo de Excel existe y es accesible
                return System.IO.File.Exists(path);
            }
            //abrir archivo excel
            public void OpenExcelFile()
            {
                if (VerifyExcelFile())
                {
                    // Lógica para abrir y leer el archivo de Excel
                    Console.WriteLine("Archivo de Excel abierto correctamente.");
                }
                else
                {
                    Console.WriteLine("El archivo de Excel no existe o no es accesible.");
                }
            }
        }

}
