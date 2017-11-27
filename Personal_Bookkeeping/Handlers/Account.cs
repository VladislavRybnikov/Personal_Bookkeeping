using System.Collections.Generic;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public IBalance Balance { get; set; }

        public List<ISpending> Spendings { get; set; }
        public List<IEarning> Earnings { get; set; }

        public Account(string name, string password, IBalance balance)
        {
            Spendings = new List<ISpending>();
            Earnings = new List<IEarning>();
            Name = name;
            Password = password;
            Balance = balance;
        }

        public IResult SpendMoney(ISpending spending)
        {
            if (this.Balance.Currency.Name.Equals("USD"))
                spending.Cost.ConvertToUSD();
            else if(this.Balance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState("EUR").Name))
                spending.Cost.ConvertToEUR();
            else if (this.Balance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState("UAH").Name))
                spending.Cost.ConvertToUAH();

            IResult result = new Result();
            result.Success = false;
            if (this.Balance.Count >= spending.Cost.Count)
            {
                this.Balance.Count -= spending.Cost.Count;
                this.Spendings.Add(spending);
                result.Message = string.Format("{0} spent {1} on {2}", this.Name,
                    spending.Cost.GetStrValue(), spending.Name);
                result.Success = true;
            }
            else
                result.Message = "not enough money";

            return result;
        }

        public IResult ReceiveMoney(IEarning earning)
        {
            IResult result = new Result();
            if (this.Balance.Currency.Name.Equals("USD"))
                earning.Amount.ConvertToUSD();
            else if (this.Balance.Currency.Name.Equals("EUR"))
                earning.Amount.ConvertToEUR();
            else if (this.Balance.Currency.Name.Equals("UAH"))
                earning.Amount.ConvertToUAH();

            this.Balance.Count += earning.Amount.Count;
            this.Earnings.Add(earning);
            result.Success = true;
            result.Message = string.Format("{0} received {1} ({2})", this.Name,
                earning.Amount.GetStrValue(), earning.Name);

            return result;
        }

        public string GetBalanceStrValue()
        {
            return Balance.GetStrValue();
        }
    }
}
