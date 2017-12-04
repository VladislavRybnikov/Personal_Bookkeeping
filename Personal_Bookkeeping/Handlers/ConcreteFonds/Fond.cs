using System.Collections.Generic;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.FondAbstract;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;
using Personal_Bookkeeping.Enums;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Handlers.ConcreteFonds
{
    public class Fond : IFond
    {
        public string Name { get; set; }
        public List<IAccount> Members { get; set; }
        public IBalance FondBalance { get; set; }
        public List<ITransaction> Transactions { get; set; }

        public Fond(string name, IBalance initialBalance)
        {
            this.Name = name;
            this.FondBalance = initialBalance;

            this.Members = new List<IAccount>();
            this.Transactions = new List<ITransaction>();
        }

        public IResult AddMember(IAccount account)
        {
            Result result = Result.GetDefaultResult();
            if (account != null)
            {
                Members.Add(account);
                result.Success = true;
                result.Message = MessageHolder.GetMessage(MessageType
                    .AccountAdd) + this.Name;
            }
            else
            {
                result.Message = MessageHolder.GetMessage(MessageType
                    .CanntAdd) + this.Name;
            }
            return result;
        }

        public string GetString()
        {
            return this.Name;
        }

        public IResult ReceiveMoney(ITransaction earning)
        {
            IResult result = new Result();
            if (this.FondBalance.Currency.Name.Equals(CurrencyType.USD
                .ToString()))
                earning.Amount.ConvertToUSD();
            else if (this.FondBalance.Currency.Name.Equals(CurrencyType
                .EUR.ToString()))
                earning.Amount.ConvertToEUR();
            else if (this.FondBalance.Currency.Name.Equals(CurrencyType
                .UAH.ToString()))
                earning.Amount.ConvertToUAH();

            this.FondBalance.Count += earning.Amount.Count;
            this.Transactions.Add(earning);
            result.Success = true;
            result.Message = string.Format(MessageHolder.GetMessage(MessageType.EarnMoney), this.Name,
                earning.Amount.GetStrValue(), earning.Name);

            return result;
        }

        public IResult SpendMoney(ITransaction spending)
        {
            if (this.FondBalance.Currency.Name.Equals(CurrencyType.USD))
                spending.Amount.ConvertToUSD();
            else if (this.FondBalance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.EUR.ToString()).Name))
                spending.Amount.ConvertToEUR();
            else if (this.FondBalance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.UAH.ToString()).Name))
                spending.Amount.ConvertToUAH();

            IResult result = new Result();
            result.Success = false;
            if (this.FondBalance.Count >= spending.Amount.Count)
            {
                this.FondBalance.Count -= spending.Amount.Count;
                this.Transactions.Add(spending);
                result.Message = string.Format(MessageHolder
                    .GetMessage(MessageType.SpentMoney), this.Name,
                    spending.Amount.GetStrValue(), spending.Name);
                result.Success = true;
            }
            else
                result.Message = MessageHolder.GetMessage(MessageType
                    .NotEnoughMoney);

            return result;
        }

        public IResult HasMember(IAccount account)
        {
            IResult result = Result.GetDefaultResult();
            result.Message = string.Format(MessageHolder.GetMessage(MessageType
                .NotAMember), account.Name);
            foreach (var fondAccount in this.Members)
            {
                if (fondAccount.Equals(account))
                {
                    result.Success = true;
                    result.Message = string.Format(MessageHolder
                        .GetMessage(MessageType.FondMember), account.Name);
                }
            }
            return result;
        }
    }
}
