using Personal_Bookkeeping.Abstract.Common.FondAbstract;

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
