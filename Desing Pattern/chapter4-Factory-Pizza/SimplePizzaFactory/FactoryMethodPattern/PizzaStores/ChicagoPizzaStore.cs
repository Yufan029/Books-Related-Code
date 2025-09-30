using FactoryMthodPattern.Pizzas;
using FactoryMthodPattern.Pizzas.ChicagoPIzzas;

namespace FactoryMthodPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {

            if (type.Equals("cheese"))
            {
                return new ChicagoCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                return new ChicagoClamPizza();
            }

            return null;
        }
    }
}
