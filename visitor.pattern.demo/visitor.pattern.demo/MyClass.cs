using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor.pattern.demo
{
    class MyClass: IOriginalInterface 
    {
        //Initial or default value
        private int myInt = 5;

        public int getMyInt() {
            return myInt;
        }

        public void setMyInt(int myInt) {
            this.myInt = myInt;
        }

        public void accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer {0}", myInt );
            visitor.visit(this);
            Console.WriteLine("\nValue of the integer now: {0}", myInt );
        }
    }
}
