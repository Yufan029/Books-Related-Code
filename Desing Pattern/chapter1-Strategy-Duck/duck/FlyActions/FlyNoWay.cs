using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck.FlyActions
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
