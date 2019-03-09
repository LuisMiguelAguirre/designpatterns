using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Abstract Factory Pattern Demo");
            ActionMovieFactory actionMovies = new ActionMovieFactory();
            ITollywoodMovie tAction = actionMovies.GetTollywoodMovie();
            IBollywoodMovie bAction = actionMovies.GetBollywoodMovie();

            Console.WriteLine("Action movies are: ");
            Console.WriteLine(tAction.MovieName());
            Console.WriteLine(bAction.MovieName());

            ComedyMovieFactory comedyMovies = new ComedyMovieFactory();
            ITollywoodMovie tComedy = comedyMovies.GetTollywoodMovie();
            IBollywoodMovie bComedy = comedyMovies.GetBollywoodMovie();

            Console.WriteLine("Comedy movies are: ");
            Console.WriteLine(tComedy.MovieName());
            Console.WriteLine(bComedy.MovieName());


            Console.ReadLine();

        }
    }
}
