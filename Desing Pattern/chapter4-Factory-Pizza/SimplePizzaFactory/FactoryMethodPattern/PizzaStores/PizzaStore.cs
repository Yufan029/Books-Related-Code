using FactoryMthodPattern.Pizzas;

namespace FactoryMthodPattern.PizzaStores
{
    public abstract class PizzaStore
    {
        // key part, tie the creation and usage together,
        // mark it as abstract
        // make the subclass to create.
        public abstract IPizza CreatePizza(string type);

        public IPizza OrderPizza(string type)
        {
            IPizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
