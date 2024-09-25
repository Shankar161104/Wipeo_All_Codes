using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimationMovieFactory objAnimationFactory = new AnimationMovieFactory();

            IHollywoodMovie objIHollywood = objAnimationFactory.GetHollywoodMovie();
            IBollywoodMovie objIBollywood = objAnimationFactory.GetBollywodMovie();

            Console.WriteLine($"Animation movies from HOLLYWOOD::{objIHollywood.MovieName}  BOLLYWOOD::{objIBollywood.MovieName}");


            HorrorMovieFactory objHorrorFactory = new HorrorMovieFactory();

            IHollywoodMovie objIHollywood1 = objHorrorFactory.GetHollywoodMovie();
            IBollywoodMovie objIBollywood1 = objHorrorFactory.GetBollywodMovie();

            Console.WriteLine($"Horror movies from HOLLYWOOD::{objIHollywood1.MovieName}  BOLLYWOOD::{objIBollywood1.MovieName}");


            Console.ReadLine();
        }
    }
}
