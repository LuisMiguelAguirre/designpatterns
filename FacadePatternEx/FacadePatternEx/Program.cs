using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roboparts;
using robotfacade;

namespace FacadePatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Facade pattern demo ***");
            RobotFacade rf1 = new RobotFacade();
            rf1.ConstructRobot("Green", "Iron");
            RobotFacade rf2 = new RobotFacade();
            rf2.ConstructRobot("Blue", "Steel");
            Console.ReadLine();
        }
    }
}
