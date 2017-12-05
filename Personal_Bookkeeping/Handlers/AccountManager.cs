using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Holders;
using Personal_Bookkeeping.Entities.Common.Result;

namespace Personal_Bookkeeping.Handlers
{
    public static class AccountManager
    {
        public static IResult Register(string name, string password, Balance balance)
        {
            Account account = new Account(name, password, balance);
            AccountHolder.CurrentAccount = account;

            return new Result();
        }
    }
}
