using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory = new ConcreteFactory();
            IAnimal DuckType = animalFactory.GetAnimalType("Duck");
            DuckType.Speak();

            
            IAnimal TigerType = animalFactory.GetAnimalType("Tiger");
            TigerType.Speak();

            Console.ReadLine();
        }
    }
}
