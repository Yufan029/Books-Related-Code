using duck.FlyActions;
using duck.QuackActions;

namespace duck.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.flyBehavior = new FlyWithWings();
            this.quackBehavior = new Quack();
        }

        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
