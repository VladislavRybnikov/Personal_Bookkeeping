using Personal_Bookkeeping.Abstract.Common.Result;

namespace Personal_Bookkeeping.Abstract.Common.ProfitAndLesion
{
    public interface IMoneyHandler
    {
        IResult SpendMoney(ISpending spending);
        IResult ReceiveMoney(IEarning earning);
    }
}
