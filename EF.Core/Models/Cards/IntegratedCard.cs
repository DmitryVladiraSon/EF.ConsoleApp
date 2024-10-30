namespace EF.Core.Models.Cards
{
    public class IntegratedCard : DiscountCard
    {
        public override string Name => "Integrated Card";

        public override decimal Discount => 0.15m;

        public override decimal? GetAmount => 25000;

    }
}
