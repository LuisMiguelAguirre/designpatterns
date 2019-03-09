using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter.pattern.demo
{
    interface IExpression
    {
        void interpret(Context ic);
    }
}
