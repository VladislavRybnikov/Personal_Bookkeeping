using Personal_Bookkeeping.Abstract.Common.Prototyping;
using Personal_Bookkeeping.Abstract.Common.Result;


namespace Bookkeeping.Entities.Common.Result
{
    public class Result : IResult, IResultPrototype
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static Result GetDefaultResult()
        {
            Result result = new Result();
            result.Message = "default message";
            result.Success = false;
            return result;
        }

        public IResult Clone()
        {
            return this.MemberwiseClone() as IResult;
        }
    }
}
