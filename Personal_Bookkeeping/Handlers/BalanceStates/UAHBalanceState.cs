using Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class UAHBalanceState : IBalanceState
    {
        public double IndexToDollar { get; set; }
        public string Name { get; set; }
        private Result _stateResult;

        public UAHBalanceState()
        {
            Name = "UAH";
            IndexToDollar = 0.037;
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
            IResult result = _stateResult.Clone();
            result.Success = false;
            result.Message = "Already in " + this.Name;
            return result;
        }

        public IResult ConvertToEUR(IBalance balance)
        {
            USDBalanceState eur = (USDBalanceState)StateFactoryHolder
                .factory.GetBalanceState("EUR");
            balance.Count = balance.Count * balance.Currency.IndexToDollar / eur.IndexToDollar;
            balance.Currency = eur;

            IResult result = _stateResult.Clone();
            result.Message = "Converted to " + eur.Name;
            result.Success = true;
            return result;
        }
        public string GetStrValue(double count)
        {
            return count.ToString("#.###") + " " + this.Name;
        }
    }
}
