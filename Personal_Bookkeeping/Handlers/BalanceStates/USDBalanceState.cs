using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class USDBalanceState : IBalanceState
    {
        public string Name { get; set; }
        public double IndexToDollar { get; set; }
        private Result _stateResult;

        public USDBalanceState()
        {
            Name = "USD";
            IndexToDollar = 1;
            _stateResult = Result.GetDefaultResult();
        }

        public IResult ConvertToUSD(IBalance balance)
        {
            IResult result = _stateResult.Clone();
            result.Success = false;
            result.Message = "Already in " + this.Name;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            UAHBalanceState uah = (UAHBalanceState)StateFactoryHolder
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
            return count.ToString("0.000") + " " + this.Name;
        }

    }
}
