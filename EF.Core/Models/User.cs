using EF.Core.Models.Cards;

namespace EF.Core.Models
{
    public class User
    {
        public User( string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal AccumuletedAmount { get; set; } 
        public List<DiscountCard> DiscountCards { get; set; } = new List<DiscountCard>();
    }
}
// Покупка => Amount > DicountAmount

