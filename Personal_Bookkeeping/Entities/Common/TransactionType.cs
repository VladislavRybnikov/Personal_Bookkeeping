using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Entities.Common
{
    public class TransactionType : ITransationType
    {
        public string Value { get; set; }

        public TransactionType(string value)
        {
            Value = value;
        }
    }
}
