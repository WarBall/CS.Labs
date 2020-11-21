using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs5.Task2
{
    class MatrixMultiply
    {
        private static object a;

        //Выводит всех элементов массива
        static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
        //Перемножение и сложение элементов массива
        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];

            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            };

            return result;
        }
        //Заполнение двумерного массива [2х2]
        static void Input(int[,] dst)
        {
            for (int r = 0; r < dst.GetLength(0); r++)
            {
                for (int c = 0; c < dst.GetLength(1); c++)
                {
                    Console.WriteLine("Enter value for [{0}, {1}] : ", r, c);
                    string s = Console.ReadLine();
                    dst[r, c] = int.Parse(s);
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Input(a);

            int[,] b = new int[2, 2];
            Input(b);

            Output(Multiply(a, b));

            Console.ReadKey();
        }
    }
}
