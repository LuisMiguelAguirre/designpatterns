using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    class MotorCycle:IBuilder
    {
        private Product product = new Product();
        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 headlights are added");
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
