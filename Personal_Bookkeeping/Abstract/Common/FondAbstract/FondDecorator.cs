using System;
using System.Collections.Generic;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Abstract.Common.FondAbstract
{
    public abstract class FondDecorator : IFond
    {
        public IBalance FondBalance { get; set; }
        public List<IAccount> Members { get; set; }
        public string Name { get; set; }

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
            throw new NotImplementedException();
        }

        public IResult ReceiveMoney(IEarning earning)
        {
            throw new NotImplementedException();
        }

        public IResult SpendMoney(ISpending spending)
        {
            throw new NotImplementedException();
        }

        public virtual string GetString()
        {
            return this.Name;
        }
    }
}
