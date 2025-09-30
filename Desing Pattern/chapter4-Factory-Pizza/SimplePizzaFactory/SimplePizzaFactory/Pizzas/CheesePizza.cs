namespace SimplePizzaFactory.Pizzas
{
    public class CheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("bake cheese pizza");
        }

        public void Box()
        {
            Console.WriteLine("Box cheese pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cut cheese pizza");
        }

        public void Prepare()
        {
            Console.WriteLine("Prepare cheese pizza");
        }
    }
}
