using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace visitor.pattern.demo
{
    interface IVisitor
    {
        void visit(MyClass myClassElement);
    }
}
