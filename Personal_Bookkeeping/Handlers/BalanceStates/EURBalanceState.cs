using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class EURBalanceState : IBalanceState
    {
        public double IndexToDollar { get; set; }
        public string Name { get; set; }
        private Result _stateResult;

        public EURBalanceState()
        {
            _stateResult = Result.GetDefaultResult();
        }

        public IResult ConvertToUSD(IBalance balance)
        {
            USDBalanceState usd = (USDBalanceState)StateFactoryHolder
                .factory.GetBalanceState("USD");
            balance.Count = balance.Count * balance.Currency.IndexToDollar / usd.IndexToDollar;
            balance.Currency = usd;

            IResult result = _stateResult.Clone();
            result.Message = "Converted to " + usd.Name;
            result.Success = true;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            USDBalanceState uah = (USDBalanceState)StateFactoryHolder
                .factory.GetBalanceState("UAH");
            balance.Count = balance.Count * balance.Currency.IndexToDollar / uah.IndexToDollar;
            balance.Currency = uah;

            IResult result = _stateResult.Clone();
            result.Message = "Converted to " + uah.Name;
            result.Success = true;
            return result;
        }

        public IResult ConvertToEUR(IBalance balance)
        {
            IResult result = _stateResult.Clone();
            result.Success = false;
            result.Message = "Already in " + this.Name;
            return result;
        }
        public string GetStrValue(double count)
        {
            return count.ToString("#.###") + " " + this.Name;
        }
    }
}
