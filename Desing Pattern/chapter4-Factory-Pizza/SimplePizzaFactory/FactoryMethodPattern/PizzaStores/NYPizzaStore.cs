using FactoryMthodPattern.Pizzas;
using FactoryMthodPattern.Pizzas.NYPizzas;

namespace FactoryMthodPattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }

            return null;
        }
    }
}
