using Personal_Bookkeeping.Abstract.Common;
using System.Collections.Generic;


namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class BalanceStateFactory
    {
        Dictionary<string, IBalanceState> states = 
            new Dictionary<string, IBalanceState>();

        public BalanceStateFactory()
        {
            states.Add("USD", new USDBalanceState());
            states.Add("UAH", new UAHBalanceState());
            states.Add("EUR", new EURBalanceState());
        }

        public IBalanceState GetBalanceState(string key)
        {
            if (states.ContainsKey(key))
                return states[key];
            else
                return null;
        }
    }
}
