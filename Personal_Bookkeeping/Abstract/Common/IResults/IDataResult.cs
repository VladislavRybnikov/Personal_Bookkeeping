namespace Personal_Bookkeeping.Abstract.Common.IResults
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
