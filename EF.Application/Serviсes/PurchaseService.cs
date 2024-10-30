using EF.Core;
using EF.Core.Models;
using EF.Core.Models.Cards;

namespace EF.Application.Serviсes
{
    public class PurchaseService
    {
        public bool MakePurchase(User user, Product product)
        {
            if (user.DiscountCards.Count != 0)
            {
                var discountCard = user.DiscountCards
                    .OrderByDescending(x => x.Discount)
                    .FirstOrDefault();

                var amount = product.Cost - (product.Cost * discountCard.Discount);

                user.AccumuletedAmount += amount;
                Console.WriteLine($"Имя/Сумма пользователя {user.Name}/{user.AccumuletedAmount} Сумма покупки {amount} Скидочная карта {discountCard.Name}/{discountCard.Discount}");
            }
            else
            {
                user.AccumuletedAmount += product.Cost; // Начислили баллы
                Console.WriteLine($"Имя/Сумма пользователя {user.Name}/{user.AccumuletedAmount} Сумма покупки {product.Cost} скидки нет");
            }
            AddingDiscountCardsToUser(user);
            return true;
        }

        private void AddingDiscountCardsToUser(User user)
        {
            if (5000 <= user.AccumuletedAmount && user.AccumuletedAmount < 12500)
            {
                user.DiscountCards.Add(new TubeCard());
            }
            else if (12500 <= user.AccumuletedAmount && user.AccumuletedAmount < 25000)
            {
                user.DiscountCards.Add(new IntegratedCard());
            }
            else if (user.AccumuletedAmount > 25000)
            {
                user.DiscountCards.Add(new TransistorCard());
            }
        }
    }
}
