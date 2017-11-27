using System;

namespace Personal_Bookkeeping.Abstract.Common.Result
{
    public interface IResult 
    {
        bool Success { get; set; }
        string Message { get; set; }

    }
}
