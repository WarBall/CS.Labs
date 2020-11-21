using System;
using System.IO;

namespace CS.Labs7.Task3
{
    public class CopyFileUpper
    {
        static void Main()
        {
            string sFrom, sTo;
            StreamReader srForm;//ссылка на входной файл
            StreamWriter swTo;//ссылка на выходной файл

            Console.WriteLine("Copy from: ");
            sFrom = Console.ReadLine();

            Console.WriteLine("Copy to: ");
            sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

            try
            {
                using (srForm = new StreamReader(sFrom))
                using (swTo = new StreamWriter(sTo))
                {

                    while (srForm.Peek() != -1)
                    {
                        string sBuffer = srForm.ReadLine();
                        sBuffer = sBuffer.ToUpper();
                        swTo.WriteLine(sBuffer);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Input file not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
