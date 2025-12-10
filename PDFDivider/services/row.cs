using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFDivider.Services
{
    public class row
    {
       

        public int No { get; set; }
        public int year { get; set; }
        public string month { get; set; }
        public int pgInicial { get; set; }
        public int pgFinal { get; set; }
        public string titulo {get;set; }

        public row(string rawdata)
        {
            string[] data = rawdata.Split(';');
            No = int.Parse(data[1]);
            year = int.Parse(data[2]);
            month = data[3];
            pgInicial = int.Parse(data[4]);
            pgFinal = int.Parse(data[5]);
            titulo = data[6];

        }
        public string titleFormat()
            {
            return $"{No}---{pgInicial}-{pgFinal}";
        }

    }
    public class  listROw
    {
        public List<row> wholeROW;
        public listROw()
        {
         wholeROW   = new List<row>();
        }
        public void addRow(row newRow)
        {
            wholeROW.Add(newRow);
        }

    }
}
