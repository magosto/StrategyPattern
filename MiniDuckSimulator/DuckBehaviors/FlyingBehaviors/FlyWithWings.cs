using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDuckSimulator.DuckBehaviors.FlyingBehaviors
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying!");
        }
    }
}
