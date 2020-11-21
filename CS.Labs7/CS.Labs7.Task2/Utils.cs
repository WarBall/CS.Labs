using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Labs7.Task2
{
    class Utils
    {
        //Нахождение большего их 2х чисел
        public static int Greater(int a, int b)
        {
            int max = (a > b) ? a : b;
            return max;
        }

        //Перемена местами значений
        public static void Swap(ref int a, ref int b)
        {
            int num = a;
            a = b;
            b = num;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k, f;
            bool ok = true;

            if (n < 0)
            {
                ok = false;
            }
;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                f = 0;
                ok = false;
                ;
            }
            answer = f;
            return ok;
        }
        //Перезапись строки в обратнов порядке
        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            {
                sRev = sRev + s[k];
            }

            s = sRev;
        }
    }
}
