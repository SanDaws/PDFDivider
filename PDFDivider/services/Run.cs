using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
    public static class Run
    {
        public static void Execute(PDFManager Pdf,ExcelManager Excel)
        {
            Excel.LoadExcel();
            //crear folders
            foreach (int folder in Excel.AllRows.Keys)
            {
                Pdf.enrutadoCarpetaFinal(folder);
            }
            //
            foreach (KeyValuePair<int,listROw> item in Excel.AllRows)
            {
                Pdf.SetwholeFileFromInDir(item.Key);
                Pdf.LoadPDFFile();
                listROw currentList = item.Value;
                foreach (row rw in currentList.wholeROW)
                {
                    Pdf.RangePages(rw.pgInicial, rw.pgFinal);
                    Pdf.FinalFileGenerate();
                    string outputPath = System.IO.Path.Combine(Pdf.OutputDirectory, rw.titleFormat() + ".pdf");
                    Pdf.SavePDFFile(outputPath);



                }

            }


        }
    }
}
