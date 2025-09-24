using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Components
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
