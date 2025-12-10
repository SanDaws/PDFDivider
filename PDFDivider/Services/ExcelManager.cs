using NPOI.SS.Formula.Functions;
using NPOI.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
        public class ExcelManager
        {
        /// <summary>
        /// change of plans , this class will manage excel files in the future
        /// rn is only to open a csv file and read data from it
        /// </summary>
        public Dictionary<int,listROw> AllRows;
        public List<row> WholeFile;
        private string Excelpath { get; set; }
        
        public ExcelManager(string path)
            {
                Excelpath = path;
                WholeFile = new List<row>();
                AllRows = new Dictionary<int, listROw>();

        }


        public  void LoadExcel()
        {
            using (StreamReader reader = File.OpenText(Excelpath)){
                
                string line;
                //skip header
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    row newRow = new row(line);

                    if (!AllRows.ContainsKey(newRow.No))
                    {
                        AllRows[newRow.No] = new listROw();
                    }
                    AllRows[newRow.No].addRow(newRow);


                }
            }
        }
        //public bool SetRoute(string path)
        //    {
        //    if (!VerifyExcelFile(Excelpath))
        //    {
        //        return false;
        //    }
        //    Excelpath = path;
        //    return true;



        //}

        ////verificar archivo excel
        //public bool VerifyExcelFile(string path)
        //    {
        //        // Lógica para verificar si el archivo de Excel existe y es accesible
        //        return System.IO.File.Exists(path);
        //    }
        //    //abrir archivo excel
        //    public void OpenExcelFile(string path)
        //    {
        //        if (VerifyExcelFile(path))
        //        {
        //            // Lógica para abrir y leer el archivo de Excel
        //            Console.WriteLine("Archivo de Excel abierto correctamente.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("El archivo de Excel no existe o no es accesible.");
        //        }
        //    }
    }

}
