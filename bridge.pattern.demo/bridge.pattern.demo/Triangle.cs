using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    class Triangle: Shape
    {
        public Triangle(IColor c) : base(c) { }


        public override void drawShape(int border)
        {
            Console.WriteLine(" This Triangle is colored with: ");
            color.fillWithColor(border);
        }

        public override void modifyBorder(int border, int increment)
        {
             Console.WriteLine("\nNow we are changing the border length "+increment+ " times");
             border = border * increment;
             drawShape(border);
        }
    }
}
