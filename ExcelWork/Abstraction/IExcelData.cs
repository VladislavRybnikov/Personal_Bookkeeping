using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Abstraction
{
    public interface IExcelData
    {
        int CurrentWorkBook { get; set; }
        int CurrentSheet { get; set; }
        ITable Table { get; set; }
    }
}
