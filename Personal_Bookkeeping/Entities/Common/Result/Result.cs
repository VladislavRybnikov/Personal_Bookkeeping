using Personal_Bookkeeping.Abstract.Common.Prototyping;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Holders;
using Personal_Bookkeeping.Enums;

namespace Personal_Bookkeeping.Entities.Common.Result
{
    public class Result : IResult, IResultPrototype
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static Result GetDefaultResult()
        {
            Result result = new Result
            {
                Message = MessageHolder.GetMessage(MessageType.Default),
                Success = false
            };
            return result;
        }

        public IResult Clone()
        {
            return this.MemberwiseClone() as IResult;
        }
    }
}
