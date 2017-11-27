using System;
using System.Collections.Generic;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common.IResults;

namespace Personal_Bookkeeping.Abstract.Common.FondAbstract
{
    public abstract class FondDecorator : IFond
    {
        public IBalance FondBalance { get; set; }
        public List<IAccount> Members { get; set; }
        public string Name { get; set; }
        public List<ISpending> Spendings { get; set; }
        public List<IEarning> Earnings { get; set; }

        private IFond _component;

        public FondDecorator(IFond component)
        {
            if (component.Members != null)
                Members = component.Members;
            else
                Members = new List<IAccount>();

            _component = component;
        }

        public IResult AddMember(IAccount account)
        {
            return this._component.AddMember(account);
        }

        public IResult ReceiveMoney(IEarning earning)
        {
            return this._component.ReceiveMoney(earning);
        }

        public IResult SpendMoney(ISpending spending)
        {
            return this._component.SpendMoney(spending);
        }

        public virtual string GetString()
        {
            return this._component.GetString();
        }
    }
}
