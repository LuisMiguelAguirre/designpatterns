using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class BollywoodComedyMovie: IBollywoodMovie
    {
        public string MovieName()
        {
            return "Munna Bhai MBBS is a Bollywood Comedy Movie";
        }
    }
}
