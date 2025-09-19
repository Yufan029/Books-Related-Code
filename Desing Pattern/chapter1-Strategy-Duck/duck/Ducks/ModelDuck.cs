using duck.FlyActions;
using duck.QuackActions;

namespace duck.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.flyBehavior = new FlyNoWay();
            this.quackBehavior = new Quack();
        }

        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
