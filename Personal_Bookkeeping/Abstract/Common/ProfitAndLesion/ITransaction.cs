using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Bookkeeping.Abstract.Common.ProfitAndLesion
{
    public interface ITransaction : IPLBase
    {
        IBalance Amount { get; set; }
        ITransationType Type { get; set; }
        String Time { get; set; }
    }
}
