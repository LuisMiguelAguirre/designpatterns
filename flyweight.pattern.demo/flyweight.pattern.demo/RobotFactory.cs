using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flyweight.pattern.demo
{
    class RobotFactory
    {
        Dictionary<string, IRobot> shapes = new Dictionary<string, IRobot>();

        public int TotalObjectsCreated() {
            return shapes.Count;
        }

        public IRobot GetRobotFromFactory(string RobotCategory) {

            IRobot robotCategory = null;
            if (shapes.ContainsKey(RobotCategory))
            {
                bool exist = shapes.TryGetValue(RobotCategory, out robotCategory);

            }
            else {
                switch (RobotCategory)
                {
                    case "small":
                        Console.WriteLine("We do not have Small Robot. So we are creating a Small Robot now.");
                        robotCategory = new SmallRobot();
                        shapes.Add("small", robotCategory);
                        break;
                    case "large":
                        Console.WriteLine("We do not have Large Robot. So we are creating a Large Robot now.");
                        robotCategory = new LargeRobot();
                        shapes.Add("large", robotCategory);
                        break;
                    default:
                        break;
                }
            }
            return robotCategory;
        }
                
        

    }
}
