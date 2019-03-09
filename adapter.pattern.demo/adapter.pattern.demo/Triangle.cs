using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter.pattern.demo
{
    public class Triangle
    {
        public double b { get; set; }
        public double h { get; set; }

        public Triangle()
        {
        }

        public Triangle(int b, int h)
        {
            this.b = b;
            this.h = h;
        }

    }
}
