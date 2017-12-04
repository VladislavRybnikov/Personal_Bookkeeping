using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Abstraction
{
    public interface IExcelStream : IDisposable
    {
        Application XLApplication { get; set; }
    }
}
