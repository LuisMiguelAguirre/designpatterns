using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern.demo
{
    interface IAnimalFactory
    {
         IAnimal GetAnimalType(string type);// throw new Exception();
        /*
         * {
            throw new NotImplementedException();
        }
         */
    }
}
