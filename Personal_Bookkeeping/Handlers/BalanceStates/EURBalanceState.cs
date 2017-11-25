using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.Result;
using Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class EURBalanceState : IBalanceState
    {
        public double IndexToDollar { get; set; }
        public string Name { get; set; }

        public IResult ConvertToUSD(IBalance balance)
        {
            USDBalanceState usd = (USDBalanceState)StateFactoryHolder
                .factory.GetBalanceState("USD");
            Result result = new Result();
            result.Message = "Converted to " + usd.Name;
            balance.Count = balance.Count * balance.Currency.IndexToDollar / usd.IndexToDollar;
            balance.Currency = usd;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            USDBalanceState uah = (USDBalanceState)StateFactoryHolder
                .factory.GetBalanceState("UAH");
            Result result = new Result();
            result.Message = "Converted to " + uah.Name;
            balance.Count = balance.Count * balance.Currency.IndexToDollar / uah.IndexToDollar;
            balance.Currency = uah;
            result.Success = true;
            return result;
        }

        public IResult ConvertToEUR(IBalance balance)
        {
            Result result = new Result();
            result.Success = false;
            result.Message = "Already in " + this.Name;
            return result;
        }
        public string GetStrValue(double count)
        {
            return count + " " + this.Name;
        }
    }
}
