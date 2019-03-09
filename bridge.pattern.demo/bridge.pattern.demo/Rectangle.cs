using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    class Rectangle: Shape
    {
        public Rectangle(IColor c) : base(c) { }


        public override void drawShape(int border)
        {
            Console.WriteLine(" This Rectangle is colored with: ");
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
