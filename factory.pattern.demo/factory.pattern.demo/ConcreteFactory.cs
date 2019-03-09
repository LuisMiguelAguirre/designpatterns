using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern.demo
{
    class ConcreteFactory: IAnimalFactory
    {
        public IAnimal GetAnimalType(string type)
        {
            switch (type)
            {
                case "Duck":
                    return new Duck();
                    
                case "Tiger":
                    return new Tiger();
                    
                default:
                    throw new Exception("Animal type does not exits.");
            }
        }
    }
}
