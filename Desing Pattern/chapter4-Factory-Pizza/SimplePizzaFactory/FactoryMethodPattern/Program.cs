using FactoryMthodPattern.PizzaStores;

namespace FactoryMthodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new NYPizzaStore();
            pizzaStore.OrderPizza("clam");

            var pizzaStore2 = new ChicagoPizzaStore();
            pizzaStore2.OrderPizza("veggie");

        }
    }
}
