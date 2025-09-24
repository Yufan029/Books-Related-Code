using Decorator_CoffeeShop.Components;
using Decorator_CoffeeShop.Decorators;

namespace Decorator_CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()}: {beverage.Cost():c}");


            Beverage doubleMochaWithWhipDarkRoast = new DarkRoast();
            Console.WriteLine($"{doubleMochaWithWhipDarkRoast.GetDescription()}: {doubleMochaWithWhipDarkRoast.Cost():c}");
            
            doubleMochaWithWhipDarkRoast = new Mocha(doubleMochaWithWhipDarkRoast);
            Console.WriteLine($"{doubleMochaWithWhipDarkRoast.GetDescription()} : {doubleMochaWithWhipDarkRoast.Cost():c}");
            
            doubleMochaWithWhipDarkRoast = new Mocha(doubleMochaWithWhipDarkRoast);
            Console.WriteLine($"{doubleMochaWithWhipDarkRoast.GetDescription()} : {doubleMochaWithWhipDarkRoast.Cost():c}");

            doubleMochaWithWhipDarkRoast = new Whip(doubleMochaWithWhipDarkRoast);
            Console.WriteLine($"{doubleMochaWithWhipDarkRoast.GetDescription()} : {doubleMochaWithWhipDarkRoast.Cost():c}");


            Beverage beverage3 = new HouseBlend();
            Console.WriteLine($"{beverage3.GetDescription()}: {beverage3.Cost():c2}");
            
            beverage3 = new Soy(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()}: {beverage3.Cost():c2}");

            beverage3 = new Mocha(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()}: {beverage3.Cost():c2}");

            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()}: {beverage3.Cost():c2}");
        }
    }
}
