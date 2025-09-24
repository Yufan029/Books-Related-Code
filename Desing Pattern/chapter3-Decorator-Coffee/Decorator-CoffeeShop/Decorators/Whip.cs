using Decorator_CoffeeShop.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .14;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + ", Whip";
        }
    }
}
