namespace Personal_Bookkeeping.Abstract.Common
{
    public interface ICurrencyConvertor
    {
        IBalance Convert(IBalance from, IBalanceState to);
    }
}
