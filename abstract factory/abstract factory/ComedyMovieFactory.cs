using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class ComedyMovieFactory: IMovieFactory
    {
        public ITollywoodMovie GetTollywoodMovie()
        {
            return new TollywoodComedyMovie();
        }

        public IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodComedyMovie();
        }
    }
}
