using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;

namespace Personal_Bookkeeping.Abstract.Common
{
    public interface IEarning : IPLBase
    {
        IBalance Amount { get; set; }
    }
}
