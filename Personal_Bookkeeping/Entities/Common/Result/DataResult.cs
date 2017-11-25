using Personal_Bookkeeping.Abstract.Common.Result;


namespace Bookkeeping.Entities.Common.Result
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
