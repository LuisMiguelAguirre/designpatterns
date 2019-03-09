using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    abstract class Shape
    {
        protected IColor color;
        public Shape(IColor c)
        {
            this.color = c;
        }

        public abstract void drawShape(int border);
        public abstract void modifyBorder(int border, int increment);
    }
}
