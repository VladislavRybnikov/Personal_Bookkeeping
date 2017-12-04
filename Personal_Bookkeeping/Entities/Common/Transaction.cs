using Personal_Bookkeeping.Abstract.Common.ProfitAndLesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal_Bookkeeping.Abstract.Common;

namespace Personal_Bookkeeping.Entities.Common
{
    public class Transaction : ITransaction
    {
        public IBalance Amount { get; set; }
        public ITransationType Type { get; set; }
        public String Time { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        
    }
}
