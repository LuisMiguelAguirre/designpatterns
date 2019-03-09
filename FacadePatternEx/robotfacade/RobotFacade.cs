using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using roboparts;

namespace robotfacade
{
    public class RobotFacade
    {
        RobotColor rc;
        RoboMetal rm;
        RobotBody rb;

        public RobotFacade()
        {
            rc = new RobotColor();
            rm = new RoboMetal();
            rb = new RobotBody();
        }

        public void ConstructRobot(string color, string metal) {
            Console.WriteLine("Creation of the robot start");
            rc.SetColor(color);
            rm.SetMetal(metal);
            rb.CreateBody();
            Console.WriteLine("Robot creation end");
        }

    }
}
