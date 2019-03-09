using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder carBuilder = new Car();
            IBuilder motorBuilder = new MotorCycle();

            director.Construct(carBuilder);
            Product p1 = carBuilder.GetVehicle();
            p1.show();

            director.Construct(motorBuilder);
            Product p2 = motorBuilder.GetVehicle();
            p2.show();

            Console.ReadLine();
        }
    }
}
