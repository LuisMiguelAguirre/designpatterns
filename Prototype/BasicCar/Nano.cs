using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Nano: BasicCar
    {
        public Nano(string m)
        {
            modelName = m;
        }

        public override Object Clone()
        {
            return (Nano)base.MemberwiseClone();
        }
    }
}
