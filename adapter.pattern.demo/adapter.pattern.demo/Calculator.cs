using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.pattern.demo
{
    class Calculator
    {
        Rect rectangle;
        public double getArea(Rect r) {
            rectangle = r;
            return rectangle.l * rectangle.w;
        }
    }
}
