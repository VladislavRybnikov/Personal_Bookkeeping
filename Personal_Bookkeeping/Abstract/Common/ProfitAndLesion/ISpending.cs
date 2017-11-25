using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface ISpending : IPLBase
    {
        IBalance Cost { get; set; }
    }
}
