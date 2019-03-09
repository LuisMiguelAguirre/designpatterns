using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engineering.Papers;

namespace Template_Method_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicEngineering sc = new ComputerScience();
            Console.WriteLine("Computer Sc. Papers:");
            sc.Papers();
            Console.WriteLine("");

            BasicEngineering el = new Electronics();
            Console.WriteLine("Electronics Papers");
            el.Papers();

            Console.ReadLine();
        }
    }
}
