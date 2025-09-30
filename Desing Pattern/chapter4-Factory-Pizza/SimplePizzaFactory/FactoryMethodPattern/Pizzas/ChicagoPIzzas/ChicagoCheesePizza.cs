namespace FactoryMthodPattern.Pizzas.ChicagoPIzzas
{
    public class ChicagoCheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Chicago Cheese - bake");
        }

        public void Box()
        {
            Console.WriteLine("Chicago Cheese - box");
        }

        public void Cut()
        {
            Console.WriteLine("Chicago Cheese - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("Chicago Cheese - prepare");
        }
    }
}
