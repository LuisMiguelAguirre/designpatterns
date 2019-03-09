using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter.pattern.demo
{
    /*Context class: interpretation is carried out based on our implementation.*/
    class Context
    {
        public string input;
        public Context(string input)
        {
            this.input = input;
        }

        public void getBinaryForm(string input) {
            int i = Int16.Parse(input);
            Console.WriteLine("Binary equivalent of {0} is {1}", input, "10001000");
        }

        public void printInWords(string input) {
            this.input = input;
            char[] c= input.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                switch (c[i])
                {
                    case '1':
                        Console.WriteLine("One");
                        break;
                    case '2':
                        Console.WriteLine("Two");
                        break;
                    case '3':
                        Console.WriteLine("Three");
                        break;
                    case '4':
                        Console.WriteLine("Four");
                        break;
                    case '5':
                        Console.WriteLine("Five");
                        break;
                    case '6':
                        Console.WriteLine("Six");
                        break;
                    case '7':
                        Console.WriteLine("Seven");
                        break;
                    case '8':
                        Console.WriteLine("Eight");
                        break;
                    case '9':
                        Console.WriteLine("Nine");
                        break;
                    case '0':
                        Console.WriteLine("Zero");
                        break;
                    default:
                        Console.WriteLine("* ");
                        break;
                }
            }
        }
    }
}
