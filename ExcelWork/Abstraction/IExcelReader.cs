using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Abstraction
{
    public interface IExcelReader : IExcelStream
    {
        ITable Read(string path, ICell from, ICell to, int sheetNum);
    }
}
