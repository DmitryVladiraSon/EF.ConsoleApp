using EF.Application.Serviсes;
using EF.Core;
using EF.Core.Models;
using EF.Core.Models.Cards;
using System.Text;

namespace EF.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Краточки нашего магазина");
            var myUser = new User("Artem");
            var product2500 = new Product() { Cost = 2501 };
            var product5500 = new Product() { Cost = 5501 };
            var product4500 = new Product() { Cost = 4501 };

            PurchaseService purchaseService = new PurchaseService();



            purchaseService.MakePurchase(myUser, product2500);
            purchaseService.MakePurchase(myUser, product2500);

            purchaseService.MakePurchase(myUser, product4500);
            purchaseService.MakePurchase(myUser, product5500);
            purchaseService.MakePurchase(myUser, product4500);
            purchaseService.MakePurchase(myUser, product2500);  
            
            purchaseService.MakePurchase(myUser, product4500);
            purchaseService.MakePurchase(myUser, product5500);
            purchaseService.MakePurchase(myUser, product5500);
            purchaseService.MakePurchase(myUser, product5500);
            purchaseService.MakePurchase(myUser, product5500);
            myUser.DiscountCards.Add(new QuantumCard());
            purchaseService.MakePurchase(myUser, product4500);
            purchaseService.MakePurchase(myUser, product2500);
        }
    }
}
