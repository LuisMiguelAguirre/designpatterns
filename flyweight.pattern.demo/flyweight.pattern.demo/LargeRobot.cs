using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.pattern.demo
{
    class LargeRobot:IRobot
    {

        public void Print()
        {
            Console.WriteLine("I am a large robot");
        }
    }
}
