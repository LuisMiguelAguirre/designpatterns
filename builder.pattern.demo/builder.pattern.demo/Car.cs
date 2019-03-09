using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    class Car:IBuilder
    {
        private Product product = new Product();

        public void BuildBody()
        {
            product.Add("This is a body of a car");
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("2 headlights are added");
        }

        public Product GetVehicle()
        {
            return product;
        }
    }
}
