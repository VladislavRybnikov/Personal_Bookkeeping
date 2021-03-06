﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelWork.Abstraction
{
    public interface IDataResult<T> : IExcelResult
    {
        T Data { get; set; }
    }
}
