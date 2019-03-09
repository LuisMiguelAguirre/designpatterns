using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class BasicCar: ICloneable
    {
        public string modelname;
        public int price;

        public static int setPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(100000);
            price = p;
           return price;
        }

        public string modelName
        {
            get { return modelname; }
            set { modelname = value; }
        }

        public virtual Object Clone()
        {
            return (BasicCar)base.MemberwiseClone();
        }
    }
}
