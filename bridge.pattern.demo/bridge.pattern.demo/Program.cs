using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.pattern.demo
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("*****BRIDGE PATTERN*****");
                 //Coloring Green to Triangle
                 Console.WriteLine("\nColoring Triangle:");
                 IColor green = new GreenColor();
                 Shape triangleShape = new Triangle(green);
                 triangleShape.drawShape(20);
                 triangleShape.modifyBorder(20, 3);

                 //Coloring Red to Rectangle
                 Console.WriteLine("\n\nColoring Rectangle :");
                 IColor red = new RedColor();
                 Shape rectangleShape = new Rectangle(red);
                 rectangleShape.drawShape(50);
                 //Modifying the border length twice
                 rectangleShape.modifyBorder(50,2);


                 Console.ReadLine();
        }
    }
}
