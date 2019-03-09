using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern.demo
{
    class Duck: IAnimal
    {

        public void Speak()
        {
            Console.WriteLine("Duck says Pack-pack");
        }
    }
}
