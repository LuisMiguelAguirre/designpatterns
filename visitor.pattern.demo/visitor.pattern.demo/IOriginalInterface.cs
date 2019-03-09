using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visitor.pattern.demo
{
    interface IOriginalInterface
    {
        void accept(IVisitor visitor);
    }
}
