using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Abstraction
{
    public interface IExcelResult
    {
        bool Success { get; set; }
        string Message { get; set; }
    }
}
