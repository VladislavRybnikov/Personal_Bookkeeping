using Personal_Bookkeeping.Abstract.Enums;
using System.Collections.Generic;
using System.Linq;


namespace Personal_Bookkeeping.Abstract.Holders
{
    public static class MessageHolder
    {

        private static Dictionary<MessageType, string> _messages = new Dictionary<MessageType, string>
        {
            { MessageType.Convert, "Converted to " },
            { MessageType.AlreadyIn, "Already in " },
            { MessageType.NotEnoughMoney, "not enough money" },
            { MessageType.SpentMoney, "{0} spent {1} on {2}" },
            { MessageType.EarnMoney, "{0} received {1} ({2})" },
            { MessageType.FondJoin, "{0} joined to the fond: {1}" },
            { MessageType.CanntJoin, "cann't join to {0}" },
            { MessageType.MakeContribution, "{0} make a contribution to the {1}" },
            { MessageType.FondMember, "{0} is a member of this fond" },
            { MessageType.NotAMember, "{0} is not a member of this fond" },
            { MessageType.AccountAdd, "new account added to " },
            { MessageType.CanntAdd, "can not add to " },
            { MessageType.BalanceFieldError, "Balance field is not valid" },
            { MessageType.MultiplyCheckError, "You can check only one checkBox" },
            { MessageType.Default, "Default message" }

        };

        public static string GetMessage(MessageType type)
        {
            if (_messages.Keys.Contains(type))
                return _messages[type];
            else
                return null;
        }
    }
}
