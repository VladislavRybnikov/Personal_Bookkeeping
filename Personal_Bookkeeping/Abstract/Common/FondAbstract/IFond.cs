using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Handlers;
using System.Collections.Generic;

namespace Personal_Bookkeeping.Abstract.Common.FondAbstract
{
    public interface IFond : IMoneyHandler
    {
        string Name { get; set; }
        List<IAccount> Members { get; set; }
        IBalance FondBalance { get; set; }
        IResult AddMember(IAccount account);
        string GetString();
    }
}
