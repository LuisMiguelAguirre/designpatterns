using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    class Director
    {
        IBuilder myBuilder;

        public void Construct(IBuilder builder) {
            myBuilder = builder;
            myBuilder.BuildBody();
            myBuilder.InsertWheels();
            myBuilder.AddHeadlights();
        }
    }
}
