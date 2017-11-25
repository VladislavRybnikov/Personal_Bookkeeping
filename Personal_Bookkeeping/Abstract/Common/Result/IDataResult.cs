namespace Personal_Bookkeeping.Abstract.Common.Result
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
