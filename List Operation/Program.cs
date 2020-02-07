using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operation
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
            int countTimes = 0;
            while (command!="End")
            {
                command = Console.ReadLine();
                string[] splited = command.Split();
                switch (splited[0])
                {
                    case "Add":
                        if (int.Parse(splited[1])>numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Add(int.Parse(splited[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(splited[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(splited[1]));
                        }
                        break;
                    case "Insert":
                        if (int.Parse(splited[1]) > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(splited[2]),int.Parse(splited[1]));
                        }
                        break;
                    case "Shift":
                        if (splited[1]=="left")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if(int.Parse(splited[2]) != countTimes)
                                {
                                    int currentNumber = numbers[0];
                                    numbers.Remove(currentNumber);
                                    numbers.Add(currentNumber);
                                }
                                else if (int.Parse(splited[2]) == countTimes)
                                {
                                    break;
                                }
                                countTimes++;
                            }
                            countTimes = 0;
                        }
                        break;
                    case "End":
                    break;

                    default:
                        break;
                }
            }
            if (command=="End")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
