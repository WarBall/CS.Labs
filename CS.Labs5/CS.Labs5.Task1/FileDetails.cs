﻿using System;
using System.IO;

namespace CS.Labs5.Task1
{
    class FileDetails
    {
        static void Summarize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;

            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("Total no of characters: {0}", contents.Length);
            Console.WriteLine("Total no of vowels : {0}", vowels);
            Console.WriteLine("Total no of consonants: {0}", consonants);
            Console.WriteLine("Total no of lines : {0}", lines);
        }

        static void Main(string[] args)
        {
            try
            {
                string fileName = args[0];

                using (FileStream stream = new FileStream(fileName, FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    int size = (int)stream.Length;

                    char[] contents = new char[size];

                    for (int i = 0; i < size; i++)
                    {
                        contents[i] = (char)reader.Read();
                    }

                    Summarize(contents);

                    foreach (char ch in contents)
                    {
                        Console.Write(ch);
                    }
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }

        }
    }
}
