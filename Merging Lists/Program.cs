using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();


            for (int i = 0; i < Math.Max(firstNumbers.Count,secondNumers.Count); i++)
            {
                if (i<firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }

                if (i<secondNumers.Count)
                {
                    result.Add(secondNumers[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}

