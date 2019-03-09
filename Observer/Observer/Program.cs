using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public static class MyClass {

        public static List<T> exceptAll<T>(this List<T> lista1, List<T> lista2)
        {
            return lista1.Except(lista2).Union(lista2.Except(lista1)).ToList();
        }
            
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Subject s1 = new Subject();
            IObserver o1 = new Observer1();
            IObserver o2 = new Observer2();
            
            s1.register(o1);
            s1.register(o2);
            s1.Flag = 5;
            s1.Flag = 25;
            s1.unregister(o1);
            s1.Flag = 50;

    
            /*List<string> lista1 = new List<string>() { "1", "2", "3", "4" };
            List<string> lista2 = new List<string>() { "1", "2", "3", "6" };
            List<string> except = lista1.exceptAll(lista2);

            except.ForEach(Console.WriteLine);
            */
            Console.ReadLine();
        }
    }
}
