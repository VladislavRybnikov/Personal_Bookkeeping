using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Implements
{
    public class ExcelData : IExcelData
    {
        public int CurrentWorkBook { get; set; }
        public int CurrentSheet { get; set; }
        public ITable Table { get; set; }

        public ExcelData(int book, int sheet, ITable table)
        {
            CurrentWorkBook = book;
            CurrentSheet = sheet;
            Table = table;
        }
    }
}
