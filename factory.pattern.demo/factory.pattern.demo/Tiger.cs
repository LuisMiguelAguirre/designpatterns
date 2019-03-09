using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern.demo
{
    class Tiger: IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum. . Halum");
        }
    }
}
