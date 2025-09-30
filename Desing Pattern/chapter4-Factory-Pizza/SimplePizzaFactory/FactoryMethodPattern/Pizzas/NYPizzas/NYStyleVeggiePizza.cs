namespace FactoryMthodPattern.Pizzas.NYPizzas
{
    public class NYStyleVeggiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("New York Veggie - bake");
        }

        public void Box()
        {
            Console.WriteLine("New York Veggie - box");
        }

        public void Cut()
        {
            Console.WriteLine("New York Veggie - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("New York Veggie - prepare");
        }
    }
}
