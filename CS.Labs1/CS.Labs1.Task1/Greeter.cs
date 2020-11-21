using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs1.Task1
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();

            Console.WriteLine("Heloo {0}", myName);
            Console.ReadKey();
        }
    }
}
