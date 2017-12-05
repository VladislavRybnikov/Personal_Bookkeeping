using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Abstract.Common
{
    public abstract class AccountDecorator : IAccount
    {
        private IAccount _account;
        public string Name { get; set; }
        public string Password { get; set; }
        public List<ITransaction> Transactions { get; set; }
        public IBalance Balance { get; set; }

        public AccountDecorator(IAccount account)
        {
            this._account = account;

            this.Name = account.Name;
            this.Password = account.Password;
            this.Balance = account.Balance;

            if (account.Transactions != null)
                this.Transactions = account.Transactions;
            else
                this.Transactions = new List<ITransaction>();
        }

        public string GetBalanceStrValue()
        {
            return _account.GetBalanceStrValue();
        }

        public IResult SpendMoney(ITransaction spending)
        {
            return _account.SpendMoney(spending);
        }

        public IResult ReceiveMoney(ITransaction earning)
        {
            return _account.ReceiveMoney(earning);
        }
    }
}
