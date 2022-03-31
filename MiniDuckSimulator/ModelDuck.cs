using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniDuckSimulator.DuckBehaviors.FlyingBehaviors;
using MiniDuckSimulator.DuckBehaviors.QuackBehaviors;

namespace MiniDuckSimulator
{
    public class ModelDuck : DuckBase
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
