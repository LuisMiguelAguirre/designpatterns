using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class BollywoodActionMovie: IBollywoodMovie
    {
        public string MovieName()
        {
            return "Bang Bang is a Bollywood Action Movie";
        }
    }
}
