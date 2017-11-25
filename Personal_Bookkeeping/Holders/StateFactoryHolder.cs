using Personal_Bookkeeping.Handlers.BalanceStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Bookkeeping.Holders
{
    public static class StateFactoryHolder
    {
        public static BalanceStateFactory factory = new BalanceStateFactory();
    }
}
