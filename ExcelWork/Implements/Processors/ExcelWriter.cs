using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using ExcelWork.Implements.Result;

namespace ExcelWork.Implements.Processors
{
    public class ExcelWriter : IExcelWriter
    {
        public Application XLApplication { get; set; }

        public ExcelWriter(List<int> workbooks)
        {
            XLApplication = new Application();
            foreach (int book in workbooks)
            {
                XLApplication.Workbooks.Add();
                XLApplication.SheetsInNewWorkbook = book;

            }
        }

        public ExcelWriter()
        {
            XLApplication = new Application();
            XLApplication.Workbooks.Add();
        }

        public void Dispose()
        {
            foreach (Workbook book in XLApplication.Workbooks)
            {
                book.Close();
            }
            XLApplication.Quit();
        }

        public IExcelResult Write(IExcelData data, string path)
        {
            foreach (var inform in data.Table.Data)
                this.XLApplication
                    .Workbooks[data.CurrentWorkBook]
                    .Worksheets[data.CurrentSheet]
                    .Cells[inform.Key.X, inform.Key.Y] = inform.Value;

            this.XLApplication
                .Workbooks[data.CurrentWorkBook]
                .SaveAs(path);

            return new ExcelResult();
        }

    }
}
