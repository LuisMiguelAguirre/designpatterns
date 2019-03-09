using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpreter.pattern.demo
{
    class StringToBinaryExp: IExpression
    {
        private string str;

        public StringToBinaryExp(string s)
        {
            str = s;
        }

        public void interpret(Context ic)
        {
            ic.getBinaryForm(str);
        }
    }
}
