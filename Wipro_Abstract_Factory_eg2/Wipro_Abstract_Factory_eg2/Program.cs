using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimationMovieFactory objAnimation = new AnimationMovieFactory();

            HollyWoodMovie objHollywood = objAnimation.GetHollyWoodMovie();
            BollyWoodMovie objBollywood = objAnimation.GetBollyWoodMovie();
             
            Console.WriteLine($"Animation Movies from   HOLLYWOOD::  {objHollywood.MovieName}   BOLLYWOOD::  {objBollywood.MovieName}");

            ComedyFactory objComedy = new ComedyFactory();
            objHollywood = objComedy.GetHollyWoodMovie();
            objBollywood = objComedy.GetBollyWoodMovie();


            Console.WriteLine($"Comedy Movies from   HOLLYWOOD::  {objHollywood.MovieName}   BOLLYWOOD::  {objBollywood.MovieName}");


            Console.ReadLine();
        }
    }
}
