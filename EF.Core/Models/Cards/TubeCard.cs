using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Core.Models.Cards
{
    public class TubeCard : DiscountCard
    {
        public override string Name => "Tube Card";
        public override decimal Discount => 0.05m;

        public override decimal GetAmount => 5000;
    }
}
