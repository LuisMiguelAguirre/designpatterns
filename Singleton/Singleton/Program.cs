using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Singleton
{
      

     class MakeACaptain {
        private static MakeACaptain _captain;
        
        
        private MakeACaptain() {}

        public  static MakeACaptain makeCaptain() {

            if (_captain == null)
            {
            _captain = _captain = new MakeACaptain();
                Console.WriteLine("First time that a captain is selected");
            }
            else {
                Console.WriteLine("The captains was already selected");
            }
            return _captain;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MakeACaptain myCaptain = MakeACaptain.makeCaptain();
            MakeACaptain otherCaptain = MakeACaptain.makeCaptain();

            Console.ReadLine();
        }
    }
}
