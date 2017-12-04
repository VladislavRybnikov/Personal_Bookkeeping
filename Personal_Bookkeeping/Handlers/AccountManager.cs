using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
