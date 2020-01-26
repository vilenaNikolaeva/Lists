using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Sum adjacent equal numbers

             List < double > list1 = Console.ReadLine()
                .Split().
                Select(double.Parse)
                .ToList();

              int n = 0;
                while (n < list1.Count - 1)
               {
                for (int j = 0; j < 1; j++)
                {
                    if (list1[n] == list1[n + 1])
                    {
                        double sum = list1[n] + list1[n + 1];
                        list1[n] = sum;
                        list1.Remove(list1[n + 1]);
                        n = 0;
                    }
                    else
                    {
                        n++;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",list1));
        }
    }
}
