﻿using System;

namespace ForLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);  // both loops doing the samething.. for loop much more cleaner.
                
            }






        }
    }
}
