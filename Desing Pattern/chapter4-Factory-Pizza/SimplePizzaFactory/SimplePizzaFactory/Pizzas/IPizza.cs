namespace SimplePizzaFactory.Pizzas
{
    public interface IPizza
    {
        public void Prepare();
        public void Bake();
        public void Cut();
        public void Box();
    }
}
