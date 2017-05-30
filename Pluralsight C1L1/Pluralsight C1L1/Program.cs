using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight_C1L1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fallBack = "complete";
            if (args.Length > 0)
            {
                fallBack = args[0];
            }
            Console.WriteLine("Visual Studio is " + fallBack);
        }
    }
}
