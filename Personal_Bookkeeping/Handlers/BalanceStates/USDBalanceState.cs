using Bookkeeping.Entities.Common.Result;
using Personal_Bookkeeping.Abstract.Common;
using Personal_Bookkeeping.Abstract.Common.Result;
using Personal_Bookkeeping.Holders;

namespace Personal_Bookkeeping.Handlers.BalanceStates
{
    public class USDBalanceState : IBalanceState
    {
        public string Name { get; set; }
        public double IndexToDollar { get; set; }
        public USDBalanceState()
        {
            Name = "USD";
            IndexToDollar = 1;
        }

        public string GetStrValue(double count)
        {
            return count + " " + this.Name;
        }
    
        public IResult ConvertToUSD(IBalance balance)
        {
            Result result = new Result();
            result.Success = false;
            result.Message = "Already in " + this.Name;
            return result;
        }

        public IResult ConvertToUAH(IBalance balance)
        {
            UAHBalanceState uah = (UAHBalanceState)StateFactoryHolder
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
            EURBalanceState eur = (EURBalanceState)StateFactoryHolder
                .factory.GetBalanceState("EUR");
            Result result = new Result();
            result.Message = "Converted to " + eur.Name;
            balance.Count = balance.Count * balance.Currency.IndexToDollar / eur.IndexToDollar;
            balance.Currency = eur;
            return result;
        }
    }
}
