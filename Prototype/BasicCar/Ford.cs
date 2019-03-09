using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Ford: BasicCar
    {
        public Ford(string m)
        {
            modelName = m;
        }

        public override Object Clone()
        {
            return (Ford)base.MemberwiseClone();
        }
    }
}
