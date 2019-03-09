using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    interface IBuilder
    {
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        Product GetVehicle();
    }
}
