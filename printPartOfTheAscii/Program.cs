﻿using System;

namespace printPartOfTheAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int secondChar = int.Parse(Console.ReadLine());

            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
