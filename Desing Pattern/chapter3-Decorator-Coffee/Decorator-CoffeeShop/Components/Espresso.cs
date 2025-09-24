using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Components
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espress";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
