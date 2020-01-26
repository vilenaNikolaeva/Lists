using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagon = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            int capacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input=Console.ReadLine())!="end")
            {
                string[] splitedInput = input.Split();
                if (splitedInput.Length==1)
                {
                    int passengers = int.Parse(splitedInput[0]);
                    for (int i = 0; i < wagon.Count; i++)
                    {
                        if (wagon[i]+ passengers<=capacity)
                        {
                            wagon[i] += passengers;
                            break;
                        }
                    }
                }
                else
                {
                    int passengers = int.Parse(splitedInput[1]);
                    wagon.Add(passengers);
                }
            }//neee
        }
    }
}
