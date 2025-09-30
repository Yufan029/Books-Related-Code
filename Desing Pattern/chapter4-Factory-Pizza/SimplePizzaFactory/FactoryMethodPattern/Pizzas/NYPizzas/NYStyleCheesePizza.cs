namespace FactoryMthodPattern.Pizzas.NYPizzas
{
    public class NYStyleCheesePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("New York cheese - bake");
        }

        public void Box()
        {
            Console.WriteLine("New York cheese - box");
        }

        public void Cut()
        {
            Console.WriteLine("New York cheese - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("New York cheese - prepare");
        }
    }
}
