using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Components
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast";
        }

        public override double Cost()
        {
            return 1.32;
        }
    }
}
