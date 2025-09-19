using duck.Ducks;
using duck.FlyActions;

namespace duck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.performFly();

            modelDuck.setFlyBehavior(new FlyRocketPowered());

            modelDuck.performFly();
        }
    }
}
