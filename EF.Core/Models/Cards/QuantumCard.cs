namespace EF.Core.Models.Cards
{
    public class QuantumCard : DiscountCard
    {
        public const int VALIDITY_PERIOD = 180;
        private DateTime CreationDate = DateTime.Now;

        public override string Name => "Quantum Card";

        public override decimal Discount => 0.2m;

        public override decimal? GetAmount => throw new NotImplementedException();

        public bool IsExpired()
        {
            DateTime currentDate = DateTime.Now;

            DateTime expirationDate = CreationDate.AddDays(VALIDITY_PERIOD);

            return currentDate >= expirationDate;

        }
    }
}
