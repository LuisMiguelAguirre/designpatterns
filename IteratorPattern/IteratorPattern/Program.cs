using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iterator;
using aggregate;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Iterator Pattern Demo***");
            ISubject Sc_subject = new Science();
            ISubject Ar_subjects = new Arts();

            IIterator Sc_iterator = Sc_subject.CreateIterator();
            IIterator Ar_iterator = Ar_subjects.CreateIterator();

            Console.WriteLine("Science subjects");
            Print(Sc_iterator);
            Console.WriteLine("Art subjects");
            Print(Ar_iterator);

            Console.ReadLine();

        }

        public static void Print(IIterator iterator) {
            while (!iterator.IsDone()) {
                Console.WriteLine(iterator.Next());
            }
        }

    }
}
