using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            string input;

            while ((input=Console.ReadLine())!="end")
            {
                string[] splitedInput = input.Split();
                string command =splitedInput[0];
                int number = int.Parse(splitedInput[1]);

                if (command=="Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (number==numbers[i])
                        {
                            numbers.Remove(number);
                            i--;
                        }
                    }
                }
                else if(command=="Insert")
                {
                    int indexInput = int.Parse(splitedInput[2]);
                    numbers.Insert(indexInput, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
