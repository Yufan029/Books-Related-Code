using Decorator_CoffeeShop.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_CoffeeShop.Decorators
{
    // through inheritance to get type maching
    public abstract class CondimentDecorator : Beverage
    {
        // include the object you want to decorate
        public Beverage beverage;
    }
}
