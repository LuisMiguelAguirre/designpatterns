using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor.pattern.demo
{
    class Visitor: IVisitor
    {
        public void visit(MyClass myClassElement)
        {
            Console.WriteLine("Visitor is trying to change the integer value");
            myClassElement.setMyInt(100);
            Console.WriteLine("Existing from Visitor - visit");
        }
    }
}
