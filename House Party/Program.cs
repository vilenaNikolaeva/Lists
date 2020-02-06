using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var splitedInput = input.Split(" ");
                var name = splitedInput[0];
                var command = splitedInput[2];
                if (command=="not")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list");
                    }
                }
                else if (command=="going!")
                {
                    if (names.Contains(name))
                    {
                        if (names.Contains(name))
                        {
                            Console.WriteLine($"{name} is already in the list!");
                        }
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
