using System.Collections.Generic;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using System;
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Abstract.Holders;

namespace Personal_Bookkeeping.Handlers
{
    public class Account : IAccount
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public IBalance Balance { get; set; }
        public List<ITransaction> Transactions { get; set; }

        public Account(string name, string password, IBalance balance)
        {
            Transactions = new List<ITransaction>();
            Name = name;
            Password = password;
            Balance = balance;
        }

        public IResult SpendMoney(ITransaction spending)
        {
            if (this.Balance.Currency.Name.Equals(CurrencyType.USD.ToString()))
                spending.Amount.ConvertToUSD();
            else if(this.Balance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.EUR.ToString()).Name))
                spending.Amount.ConvertToEUR();
            else if (this.Balance.Currency.Name.Equals(StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.UAH.ToString()).Name))
                spending.Amount.ConvertToUAH();

            IResult result = new Result();
            result.Success = false;
            if (this.Balance.Count >= spending.Amount.Count)
            {
                this.Balance.Count -= spending.Amount.Count;
                this.Transactions.Add(spending);
                result.Message = string.Format(MessageHolder
                    .GetMessage(MessageType.SpentMoney), this.Name,
                    spending.Amount.GetStrValue(), spending.Name);
                result.Success = true;
            }
            else
                result.Message = MessageType.SpentMoney.ToString();

            return result;
        }

        public IResult ReceiveMoney(ITransaction earning)
        {
            IResult result = new Result();
            if (this.Balance.Currency.Name.Equals(CurrencyType.USD))
                earning.Amount.ConvertToUSD();
            else if (this.Balance.Currency.Name.Equals(CurrencyType.EUR
                .ToString()))
                earning.Amount.ConvertToEUR();
            else if (this.Balance.Currency.Name.Equals(CurrencyType.UAH))
                earning.Amount.ConvertToUAH();

            this.Balance.Count += earning.Amount.Count;
            this.Transactions.Add(earning);
            result.Success = true;
            result.Message = string.Format(MessageHolder.GetMessage(MessageType
                .EarnMoney), this.Name,
                earning.Amount.GetStrValue(), earning.Name);

            return result;
        }

        public string GetBalanceStrValue()
        {
            return Balance.GetStrValue();
        }
    }
}
