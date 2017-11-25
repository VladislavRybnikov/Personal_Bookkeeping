using Personal_Bookkeeping.Abstract.Common.Result;


namespace Bookkeeping.Entities.Common.Result
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
