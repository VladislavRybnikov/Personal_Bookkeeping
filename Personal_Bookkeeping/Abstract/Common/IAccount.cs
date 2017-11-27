using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using System.Collections.Generic;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface IAccount : IMoneyHandler
    {
        string Name { get; set; }
        string Password { get; set; }
        List<ISpending> Spendings { get; set; }
        List<IEarning> Earnings { get; set; }
        IBalance Balance { get; set; }
        string GetBalanceStrValue();

    }
}
