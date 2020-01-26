using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();

            string command = string.Empty;

            while (command!="end")
            {
                command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                string[] token = command.Split();

                for (int i = 0; i < numbers.Count-1; i++)
                {
                    int number = int.Parse(token[1]);
                    int currentNumber = numbers[i];
                    if (token[0]=="Contains")
                    {
                        if (number == numbers[i])
                        {
                            Console.WriteLine("Yes");
                            
                        }
                        if (i==numbers.Count-1)
                        {
                            Console.Write("NOOoooo");
                        }
                    }
                    else if (token[0]=="PrintEven")
                    {
                        if (currentNumber%2==0)
                        {
                            Console.Write(currentNumber+ " ");
                        }
                    }
                    else if (token[0]=="PrintOdd")
                    {
                        if (currentNumber % 2 == 1)
                        {
                            Console.Write(currentNumber + " ");
                        }
                    }
                    else if (token[0]=="GetSum")
                    {
                        int sum = numbers.Sum();
                        break;
                    }
                    else if (token[0]=="Filter >=")
                    {
                        
                        if (currentNumber >= number)
                        {
                            Console.Write(string.Join(" ",currentNumber,number));
                        }
                    }
                    else if (token[0]=="Filter <")
                    {
                        if (currentNumber < number)
                        {
                            Console.Write(string.Join(" ", number));
                        }
                    }
                }//neeeeeeeeeeeeeeee
            }
        }
    }
}
