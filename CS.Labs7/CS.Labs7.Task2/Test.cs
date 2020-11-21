using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs7.Task2
{
    class Test
    {
        static void Main()
        {
            //Test the Revers method
            Console.WriteLine("Enter string to revers: ");
            string message = Console.ReadLine();

            Utils.Reverse(ref message);

            Console.WriteLine(message);
        }
    }
}
