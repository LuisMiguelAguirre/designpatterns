using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotFactory myfactory = new RobotFactory();
            Console.WriteLine("Flyweight Pattern example");

            IRobot shape = myfactory.GetRobotFromFactory("small");
            shape.Print();
            /*Here we are trying to get the objects additional 2 times. Note that from
                now onward we do not need to create additional small robots as we have
                already created this category*/

            for (int i = 0; i < 2; i++)
            {
                shape = myfactory.GetRobotFromFactory("small");
                shape.Print();
            }

            int numOfDistinctRobots = myfactory.TotalObjectsCreated();
            Console.WriteLine("Total objects created {0}", numOfDistinctRobots);

            /*Here we are trying to get the objects 5 times. Note that the second time
                onward we do not need to create additional large robots as we have already
                created this category in the first attempt(at i=0)*/

            for (int i = 0; i < 2; i++)
            {
                shape = myfactory.GetRobotFromFactory("large");
                shape.Print();
            }
            numOfDistinctRobots = myfactory.TotalObjectsCreated();
            Console.WriteLine("Total objects created {0}", numOfDistinctRobots);

            Console.ReadLine();
        }
    }
}
