using Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.Result;
using Personal_Bookkeeping.Handlers;

namespace Personal_Bookkeeping.AccountManaging
{
    public class AccountManager
    {
        public IDataResult<IAccount> Register(IAccount account)
        {
            return null;

        }
        public IDataResult<IAccount> Login(string name, string password)
        {
            return null;
        }

        public IDataResult<IAccount> Create(string name, string password, IBalance balance)
        {
            IDataResult<IAccount> dataResult = new DataResult<IAccount>();
            if (name.Length == 0 || password.Length == 0)
            {
                dataResult.Message = "empty fields";
            }
            if (password.Length < 8)
            {
                dataResult.Message = "weak password";
            }

            Account resultAccount = new Account(name, password, balance);
            dataResult.Data = resultAccount;
            
            return dataResult;
        }
       
    }
}
