using SimplePizzaFactory.Pizzas;

namespace SimplePizzaFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public IPizza OrderPizza(string type)
        {
            IPizza pizza = this.factory.createPizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
