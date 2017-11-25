using Personal_Bookkeeping.Abstract.Common;


namespace Personal_Bookkeeping.Entities.Common
{
    public class Spending : ISpending
    {
        public string Name { get; set; }
        public string Descriptin { get; set; }
        public IBalance Cost { get; set; }

        public Spending(string name, string description, IBalance cost)
        {
            this.Name = name;
            this.Descriptin = description;
            this.Cost = cost;
        }
    }
}
