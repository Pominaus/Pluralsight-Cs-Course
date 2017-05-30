using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Review.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was the last movie you watched?");
            string movieWatched = Console.ReadLine();
            Console.WriteLine("Oh, " + movieWatched + ", is that any good? \n What would you rate it out of 10?");
            int movieRating = int.Parse(Console.ReadLine());
            if (movieRating > 8)
            {
                Console.WriteLine("Wow! That good? I'll have to catch it this week");
            }
            else
            {
                Console.WriteLine("Oh, that bad huh?");
            }
        }
    }
}
