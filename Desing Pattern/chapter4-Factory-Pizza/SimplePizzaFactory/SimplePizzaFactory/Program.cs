using SimplePizzaFactory.Pizzas;

namespace SimplePizzaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore(new SimplePizzaFactory());

            IPizza pizza = pizzaStore.OrderPizza("cheese");
        }
    }
}
