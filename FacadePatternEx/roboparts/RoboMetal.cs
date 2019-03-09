using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roboparts
{
    public class RoboMetal
    {
        private string metal;
        public void SetMetal(string metal) {
            this.metal = metal;
            Console.WriteLine("Metal is set to: {0}", this.metal);
        }
    }
}
