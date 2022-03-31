using MiniDuckSimulator.DuckBehaviors.FlyingBehaviors;
using MiniDuckSimulator.DuckBehaviors.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();

        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
