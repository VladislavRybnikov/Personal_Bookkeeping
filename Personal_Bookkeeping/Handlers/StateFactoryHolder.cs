using Personal_Bookkeeping.Handlers.BalanceStates;

namespace Personal_Bookkeeping.Handlers
{
    public static class StateFactoryHolder
    {
        public static BalanceStateFactory factory = new BalanceStateFactory();
    }
}
