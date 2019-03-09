using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    class GreenColor: IColor
    {
        public void fillWithColor(int border)
        {
            Console.WriteLine("Green color with " + border + " inch border");
        }
    }
}
