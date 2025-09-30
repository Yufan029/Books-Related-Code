using SimplePizzaFactory.Pizzas;

namespace SimplePizzaFactory
{
    public class SimplePizzaFactory
    {
        public IPizza createPizza(String type)
        {
            IPizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }

            return pizza;
        }
    }
}
