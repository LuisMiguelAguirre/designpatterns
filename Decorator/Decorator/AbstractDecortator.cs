using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AbstractDecortator: Component
    {
        protected Component com;

        public void SetTheComponent(Component c) {
            com = c;
        }

        public override void doJob()
        {
            if(com!=null){

                com.doJob();

            }
        }
    }
}
