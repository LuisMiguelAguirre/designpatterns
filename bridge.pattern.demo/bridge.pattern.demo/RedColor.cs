using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    class RedColor: IColor
    {
        public void fillWithColor(int border)
        {
            Console.WriteLine("Red color with " + border + " inch border");
        }
    }
}
