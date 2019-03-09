using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder.pattern.demo
{
    class Product
    {
        private LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }

        public void Add(string part) {
            parts.AddLast(part);
        }

        public void show() {
            Console.WriteLine("Product completed as below: ");

            for (int i = 0; i < parts.Count; i++)
            {
                Console.WriteLine(parts.ElementAt(i));
            }
        }
    }
}
