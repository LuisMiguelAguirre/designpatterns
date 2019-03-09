using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter.pattern.demo
{
    class IntToWords:IExpression
    {
        private string str;

        public IntToWords(string str)
        {
            this.str = str;
        }

        public void interpret(Context ic)
        {
            ic.printInWords(str);
        }
    }
}
