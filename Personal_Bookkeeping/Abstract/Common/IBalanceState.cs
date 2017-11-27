using Personal_Bookkeeping.Abstract.Common.IResults;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface IBalanceState
    {
        string Name { get; set; }
        double IndexToDollar { get; set; }
        string GetStrValue(double count);
        IResult ConvertToUSD(IBalance balance);
        IResult ConvertToUAH(IBalance balance);
        IResult ConvertToEUR(IBalance balance);
    }
}
