﻿using System;
using System.Collections.Generic;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Abstract.Common.FondAbstract
{
    public abstract class FondDecorator : IFond
    {
        public IBalance FondBalance { get; set; }
        public List<IAccount> Members { get; set; }
        public string Name { get; set; }
        public List<ITransaction> Transactions { get; set; }

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

        public IResult ReceiveMoney(ITransaction earning)
        {
            return this._component.ReceiveMoney(earning);
        }

        public IResult SpendMoney(ITransaction spending)
        {
            return this._component.SpendMoney(spending);
        }

        public virtual string GetString()
        {
            return this._component.GetString();
        }

        public IResult HasMember(IAccount account)
        {
            return this.HasMember(account);
        }
    }
}
