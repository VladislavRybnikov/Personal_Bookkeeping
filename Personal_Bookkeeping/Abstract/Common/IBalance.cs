using Personal_Bookkeeping.Abstract.Common.Result;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface IBalance 
    {
        double Count { get; set; }
        IBalanceState Currency { get; set; }
        IResult ConvertToUSD();
        IResult ConvertToUAH();
        IResult ConvertToEUR();
        string GetStrValue();
    }
}
