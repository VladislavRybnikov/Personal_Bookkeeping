using Personal_Bookkeeping.Abstract.Common.FondAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Bookkeeping.Handlers.ConcreteFonds
{
    public class FamilyFond : FondDecorator
    {
        public string FondType { get; private set; }
        public FamilyFond(IFond component) : base(component)
        {
            FondType = "Family fond";
        }
        public override string GetString()
        {
            return base.GetString() + string.Format("(type: {0})", FondType);
        }
    }
}
