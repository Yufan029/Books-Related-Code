namespace FactoryMthodPattern.Pizzas.ChicagoPIzzas
{
    public class ChicagoClamPizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Chicago Clam - bake");
        }

        public void Box()
        {
            Console.WriteLine("Chicago Clam - box");
        }

        public void Cut()
        {
            Console.WriteLine("Chicago Clam - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("Chicago Clam - prepare");
        }
    }
}
