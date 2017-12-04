using ExcelWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Implements.Result
{
    public class TableDataResult : IDataResult<ITable>
    {
        public ITable Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
