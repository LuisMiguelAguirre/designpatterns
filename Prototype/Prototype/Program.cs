using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");
            BasicCar nano_base = new Nano("Green Nano");
            nano_base.price = 100000;
            BasicCar ford_basic = new Ford("Ford Yellow");
            ford_basic.price = 500000;

            BasicCar bc1;
        //Clone Nano Object
            bc1 = (BasicCar)nano_base.Clone();
        //Price will be more than 100000 for sure
            bc1.price = nano_base.price + BasicCar.setPrice();
            Console.WriteLine("Car is: " + bc1.modelname + " and it's price is Rs." + bc1.price);

            bc1 = (BasicCar)ford_basic.Clone();
            //Price will be more than 100000 for sure
            bc1.price = ford_basic.price + BasicCar.setPrice();
            Console.WriteLine("Car is: " + bc1.modelname + " and it's price is Rs." + bc1.price);

            Console.ReadLine();

        }
    }
}
