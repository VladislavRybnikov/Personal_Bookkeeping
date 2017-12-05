using Personal_Bookkeeping.Abstract.Common.IResults;

namespace Personal_Bookkeeping.Abstract.Common.ProfitAndLesion
{
    public interface IMoneyHandler
    {
        IResult SpendMoney(ITransaction spending);
        IResult ReceiveMoney(ITransaction earning);
    }
}
