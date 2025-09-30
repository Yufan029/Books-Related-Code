namespace FactoryMthodPattern.Pizzas.ChicagoPIzzas
{
    public class ChicagoVeggiePizza : IPizza
    {
        public void Bake()
        {
            Console.WriteLine("Chicago Veggie - bake");
        }

        public void Box()
        {
            Console.WriteLine("Chicago Veggie - box");
        }

        public void Cut()
        {
            Console.WriteLine("Chicago Veggie - cut");
        }

        public void Prepare()
        {
            Console.WriteLine("Chicago Veggie - prepare");
        }
    }
}
