using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Bookkeeping.Enums
{
    public enum MessageType
    {
        Convert, 
        AlreadyIn, 
        NotEnoughMoney, 
        SpentMoney,
        EarnMoney,
        FondJoin, 
        CanntJoin,
        MakeContribution, 
        FondMember, 
        NotAMember, 
        AccountAdd, 
        CanntAdd, 
        Success,
        BalanceFieldError, 
        MultiplyCheckError,
        Default

    }
}
