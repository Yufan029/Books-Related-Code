namespace FactoryMthodPattern.Pizzas.NYPizzas
{
    public class NYStyleClamPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("New York Clam - bake");
        }

        public void Box()
        {
            Console.WriteLine("New York Clam - box");
        }

        public void Cut()
        {
            Console.WriteLine("New York Clam - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("New York Clam - prepare");
        }
    }
}
