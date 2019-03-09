using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class ActionMovieFactory: IMovieFactory
    {
        public ITollywoodMovie GetTollywoodMovie()
        {
            return new TollywoodActionMovie();
        }

        public IBollywoodMovie GetBollywoodMovie()
        {
            return new BollywoodActionMovie();
        }
    }
}
