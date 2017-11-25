using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.Result;

namespace Personal_Bookkeeping.Handlers
{
    public class Balance : IBalance
    {
        public double Count { get; set; }
        public IBalanceState Currency { get; set; }
        public Balance(double count, IBalanceState currency)
        {
            Count = count;
            Currency = currency;
        }

        public string GetStrValue()
        {
            return Currency.GetStrValue(this.Count);
        }
        public IResult ConvertToUSD()
        {
            return this.Currency.ConvertToUSD(this);
        }
        public IResult ConvertToUAH()
        {
            return this.Currency.ConvertToUAH(this);
        }
        public IResult ConvertToEUR()
        {
            return this.Currency.ConvertToEUR(this);
        }
    }
}
