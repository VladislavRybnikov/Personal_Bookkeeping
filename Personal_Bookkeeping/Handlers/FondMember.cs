using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.FondAbstract;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using Personal_Bookkeeping.Entities.Common;
using Personal_Bookkeeping.Entities.Common.Result;
using System.Collections.Generic;
using System;
using Personal_Bookkeeping.Abstract.Holders;
using Personal_Bookkeeping.Abstract.Enums;

namespace Personal_Bookkeeping.Handlers
{
    public class FondMember : AccountDecorator
    {
        List<IFond> Fonds { get; set; }

        public FondMember(IAccount account) : base(account)
        {
            Fonds = new List<IFond>();
        }

        public IResult JoinToFond(IFond fond)
        {
            IResult result = Result.GetDefaultResult();
            if (fond != null)
            {
                Fonds.Add(fond);
                fond.AddMember(this);
                result.Success = true;
                result.Message = string.Format(MessageHolder
                    .GetMessage(MessageType.FondJoin),
                    this.Name, fond.Name);
            }
            else
                result.Message = string.Format(MessageHolder
                    .GetMessage(MessageType.CanntJoin),
                    fond.Name);

            return result;
        }

        public IResult MakeContribution(IFond fond, IBalance balance)
        {
            IResult result = Result.GetDefaultResult();
            if (fond.HasMember(this).Success)
            {
                ITransaction accountSpending = new Transaction();
                accountSpending.Name = TransactionNameHolder
                    .GetName(TransactionName.FondSpending);
                accountSpending.Description = string.Format("{0} - {1}", fond.Name,
                    balance.GetStrValue());
                accountSpending.Type = new TransactionType(TransactionTypes
                    .Spending.ToString());
                accountSpending.Time = DateTime.Now.ToLongTimeString();
                accountSpending.Amount = balance;

                ITransaction fondEarning = new Transaction();
                fondEarning.Name = TransactionNameHolder
                    .GetName(TransactionName.AccountContribution);
                fondEarning.Description = string.Format("{0} - {1}", this.Name,
                    balance.GetStrValue());
                fondEarning.Type = new TransactionType(TransactionTypes
                    .Earning.ToString());
                fondEarning.Time = DateTime.Now.ToLongTimeString();
                fondEarning.Amount = balance;

                this.SpendMoney(accountSpending);

                fond.ReceiveMoney(fondEarning);

                result.Success = true;
                result.Message = string.Format(MessageHolder
                    .GetMessage(MessageType.MakeContribution), this.Name, fond.Name);
            }
            else
                result.Message = fond.HasMember(this).Message;

            return result;
        }
    }
}
