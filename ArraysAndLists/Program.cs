using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var evens = new List<int>();
            var odds = new List<int>();

                       
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            } 
            foreach (var evenNumber in evens)
            {
                Console.WriteLine(evenNumber);
                Console.WriteLine("This is even!");
            }
            foreach (var oddNumber in odds)
            {
                Console.WriteLine(oddNumber);
                Console.WriteLine("This is odd!");
            }                           
        }
    }
}
