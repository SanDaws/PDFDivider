using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
        internal class ExcelManager
        {
            public string excelpath { get; set; }
    	public ExcelManager(string path)
            {
                excelpath = path;
            }
            //verificar archivo excel
            public bool VerifyExcelFile()
            {
                // Lógica para verificar si el archivo de Excel existe y es accesible
                return System.IO.File.Exists(excelpath);
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
