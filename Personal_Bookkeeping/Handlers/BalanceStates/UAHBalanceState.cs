using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Abstract.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    
    public class UAHBalanceState : IBalanceState
    {
        public double IndexToDollar { get; set; }
        public string Name { get; set; }
        private Result _stateResult;

        public UAHBalanceState()
        {
            Name = CurrencyType.UAH.ToString();
            IndexToDollar = 0.037;
            _stateResult = Result.GetDefaultResult();
        }

        public IResult ConvertToUSD(IBalance balance)
        {
            USDBalanceState usd = (USDBalanceState)StateFactoryHolder
                 .factory.GetBalanceState(CurrencyType.USD.ToString());
            balance.Count = balance.Count * balance.Currency.IndexToDollar
                / usd.IndexToDollar;
            balance.Currency = usd;

            IResult result = _stateResult.Clone();
            result.Message = MessageHolder.GetMessage(MessageType.Convert)
                + usd.Name;
            result.Success = true;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            IResult result = _stateResult.Clone();
            result.Success = false;
            result.Message = MessageHolder.GetMessage(MessageType.AlreadyIn)
                + this.Name;
            return result;
        }

        public IResult ConvertToEUR(IBalance balance)
        {
            EURBalanceState eur = (EURBalanceState)StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.EUR.ToString());
            balance.Count = balance.Count * balance.Currency.IndexToDollar
                / eur.IndexToDollar;
            balance.Currency = eur;

            IResult result = _stateResult.Clone();
            result.Message = MessageHolder.GetMessage(MessageType.Convert)
                + eur.Name;
            result.Success = true;
            return result;
        }
        public string GetStrValue(double count)
        {
            return count.ToString("0.000") + " " + this.Name;
        }
    }
}
