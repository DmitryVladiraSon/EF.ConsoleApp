namespace EF.Core.Models.Cards
{
    public class TransistorCard : DiscountCard
    {
        public override string Name => "Transistor Card";

        public override decimal Discount => 0.10m;

        public override decimal GetAmount => 12500;
    }
}
