using Personal_Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.IResults;
using Personal_Bookkeeping.Abstract.Enums;
using Personal_Bookkeeping.Abstract.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class USDBalanceState : IBalanceState
    {
        public string Name { get; set; }
        public double IndexToDollar { get; set; }
        private Result _stateResult;

        public USDBalanceState()
        {
            Name = CurrencyType.USD.ToString();
            IndexToDollar = 1;
            _stateResult = Result.GetDefaultResult();
        }

        public IResult ConvertToUSD(IBalance balance)
        {
            IResult result = _stateResult.Clone();
            result.Success = false;
            result.Message = MessageHolder.GetMessage(MessageType.AlreadyIn)
                + this.Name;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            UAHBalanceState uah = (UAHBalanceState)StateFactoryHolder
                .factory.GetBalanceState(CurrencyType.UAH.ToString());
            balance.Count = balance.Count * balance.Currency.IndexToDollar
                / uah.IndexToDollar;
            balance.Currency = uah;

            IResult result = _stateResult.Clone();
            result.Message = MessageHolder.GetMessage(MessageType.Convert)
                + uah.Name;
            result.Success = true;
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
