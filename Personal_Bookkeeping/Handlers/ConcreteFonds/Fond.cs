using System.Collections.Generic;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.FondAbstract;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.ConcreteFonds
{
    public class Fond : IFond
    {
        public string Name { get; set; }
        public List<IAccount> Members { get; set; }
        public IBalance FondBalance { get; set; }
        public List<ISpending> Spendings { get; set; }
        public List<IEarning> Earnings { get; set; }

        public Fond(string name, IBalance initialBalance)
        {
            this.Name = name;
            this.FondBalance = initialBalance;

            this.Members = new List<IAccount>();
            this.Spendings = new List<ISpending>();
            this.Earnings = new List<IEarning>();
        }

        public IResult AddMember(IAccount account)
        {
            Result result = Result.GetDefaultResult();
            if (account != null)
            {
                Members.Add(account);
                result.Success = true;
                result.Message = "new account added to " + this.Name;
            }
            else
            {
                result.Message = "can not add to " + this.Name;
            }
            return result;
        }

        public string GetString()
        {
            return this.Name;
        }

        public IResult ReceiveMoney(IEarning earning)
        {
            IResult result = new Result();
            if (this.FondBalance.Currency.Name.Equals("USD"))
                earning.Amount.ConvertToUSD();
            else if (this.FondBalance.Currency.Name.Equals("EUR"))
                earning.Amount.ConvertToEUR();
            else if (this.FondBalance.Currency.Name.Equals("UAH"))
                earning.Amount.ConvertToUAH();

            this.FondBalance.Count += earning.Amount.Count;
            this.Earnings.Add(earning);
            result.Success = true;
            result.Message = string.Format("{0} received {1} ({2})", this.Name,
                earning.Amount.GetStrValue(), earning.Name);

            return result;
        }

        public IResult SpendMoney(ISpending spending)
        {
            if (this.FondBalance.Currency.Name.Equals("USD"))
                spending.Cost.ConvertToUSD();
            else if (this.FondBalance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState("EUR").Name))
                spending.Cost.ConvertToEUR();
            else if (this.FondBalance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState("UAH").Name))
                spending.Cost.ConvertToUAH();

            IResult result = new Result();
            result.Success = false;
            if (this.FondBalance.Count >= spending.Cost.Count)
            {
                this.FondBalance.Count -= spending.Cost.Count;
                this.Spendings.Add(spending);
                result.Message = string.Format("{0} spent {1} on {2}", this.Name,
                    spending.Cost.GetStrValue(), spending.Name);
                result.Success = true;
            }
            else
                result.Message = "not enough money";

            return result;
        }
    }
}
