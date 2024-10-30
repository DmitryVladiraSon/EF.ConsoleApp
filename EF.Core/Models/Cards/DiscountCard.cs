namespace EF.Core.Models.Cards
{
    public abstract class DiscountCard
    {
        public abstract string Name { get;  }
        public abstract decimal Discount { get; }
        public abstract decimal? GetAmount { get; }
    }
}
//solid