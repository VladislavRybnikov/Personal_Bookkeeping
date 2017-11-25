using Personal_Bookkeeping.Abstract.Common;


namespace Personal_Bookkeeping.Entities.Common
{
    public class Earning : IEarning
    {
        public IBalance Amount { get; set; }
        public string Name { get; set; }
        public string Descriptin { get; set; }
    }
}
