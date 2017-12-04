using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using System.Collections.Generic;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface IAccount : IMoneyHandler
    {
        string Name { get; set; }
        string Password { get; set; }
        List<ITransaction> Transactions { get; set; }
        IBalance Balance { get; set; }
        string GetBalanceStrValue();

    }
}
