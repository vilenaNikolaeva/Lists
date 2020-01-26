using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int count = 0;
            List<string> guests = new List<string>();

            while (count<people)
            {
                command = Console.ReadLine();
                string[] splitedCommand = command.Split();
                string personName = splitedCommand[0];
                string verefication = splitedCommand[2];

                if (verefication == "going")
                {
                    if (!guests.Contains(personName))
                    {
                        guests.Add(personName);
                    }
                    else
                    {
                        Console.WriteLine($"{personName} is already in the list!");
                    }
                }
                if (verefication == "not")
                {
                    if (guests.Contains(personName))
                    {
                        guests.Remove(personName);
                    }
                    else
                    {
                        Console.WriteLine($"{personName} is not in the list!");
                    }
                }

                count++;
            }
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
