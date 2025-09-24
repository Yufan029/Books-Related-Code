using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Components
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaffine";
        }

        public override double Cost()
        {
            return 2.1;
        }
    }
}
