using EF.Core.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; } 

        public DiscountCard DiscountCard { get; set; }
    }
}
// Покупка => Amount > DicountAmount