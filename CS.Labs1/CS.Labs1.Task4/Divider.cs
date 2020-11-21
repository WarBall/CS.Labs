using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs1.Task4
{
    class Divider
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Введите второе число");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("Результать деления {0} на {1} равен {2}", i, j, k);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex);
            }
            Console.ReadKey();
        }
    }
}
