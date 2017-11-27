using System;

namespace Personal_Bookkeeping.Abstract.Common.IResults
{
    public interface IResult 
    {
        bool Success { get; set; }
        string Message { get; set; }

    }
}
