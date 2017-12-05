using Personal_Bookkeeping.Abstract.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Personal_Bookkeeping.Abstract.Holders
{
    public static class TransactionNameHolder
    {
        private static Dictionary<TransactionName, string> _names = 
            new Dictionary<TransactionName, string>
        {
                {TransactionName.FondSpending, "Fond spending"},
                {TransactionName.AccountContribution, "Account contribution"}
        };

        public static string GetName(TransactionName name)
        {
            if (_names.Keys.Contains(name))
                return _names[name];
            else
                return null;
        }
    }
}
