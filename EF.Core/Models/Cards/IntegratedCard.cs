using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Models.Cards
{
    public class IntegratedCard : DiscountCard
    {
        public override string Name => "Integrated Card";

        public override decimal Discount => 0.15m;

        public override decimal GetAmount => 25000;
    }
}
