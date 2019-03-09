using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.pattern.demo
{
    class CalculatorAdapter
    {
        Calculator calculator;
        Triangle triangle;

        public double getArea(Triangle t) {

            calculator = new Calculator();
            triangle = t;
            Rect r = new Rect();
            r.l = triangle.b;
            r.w = 0.5*triangle.h;

            return calculator.getArea(r);
        }

    }
}
