using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                List<string> reversedNumbers = numbers[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int k = 0; k < reversedNumbers.Count; k++)
                {
                    Console.Write($"{reversedNumbers[k]} ");
                }
            }
        }
    }
}
