using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roboparts
{
    public class RobotColor
    {
        private string color;
        public void SetColor(string color) {
            this.color = color;
            Console.WriteLine("Color is set to: {0} ", this.color );
        }
    }
}
