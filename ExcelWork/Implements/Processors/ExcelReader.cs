using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ExcelWork.Implements.Processors
{
    public class ExcelReader : IExcelReader
    {
        public Application XLApplication { get; set; }

        public ExcelReader()
        {
            XLApplication = new Application();
        }

        public ITable Read(string path, ICell from, ICell to, int sheetNum)
        {
            ITable table = new Table();
            Workbook book = XLApplication.Workbooks.Open(path);

            for (int i = from.X; i <= to.X; i++)
            {
                for(int j = from.Y; j <= to.Y; j++)
                {
                    table.Data.Add(new Cell(i,j), (book
                        .Sheets[sheetNum]
                        .Cells[i,j]).Value2.ToString());
                }
            }

            return table;
        }

        public void Dispose()
        {
            foreach (Workbook book in XLApplication.Workbooks)
            {
                book.Close();
            }
            XLApplication.Quit();
            foreach (Workbook book in XLApplication.Workbooks)
            {
                foreach (Worksheet sheet in book.Worksheets)
                    Marshal.ReleaseComObject(sheet);
                Marshal.ReleaseComObject(book);
            }
            Marshal.ReleaseComObject(XLApplication);
        }
    }
}
