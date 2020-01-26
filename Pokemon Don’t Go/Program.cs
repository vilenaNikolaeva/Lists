using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int removedIndex = 0;
            int sum = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index == numbers.Count)
                {
                    break;
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (index == i)
                    {
                        if (index < 0)
                        {
                            numbers.Remove(numbers[0]);
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                        }
                        if (numbers[i] > numbers[numbers.Count - 1])
                        {
                            int firstElement = numbers[0];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Add(firstElement);
                        }
                       
                        removedIndex = numbers[i];
                        sum += removedIndex;
                        numbers.Remove(removedIndex);

                        for (int k = 0; k < numbers.Count; k++)
                        {
                            if (numbers[k] > removedIndex)
                            {
                                int currentIndex = numbers[k];
                                int decreasedNumber = numbers[k] - removedIndex;
                                sum += decreasedNumber;
                                numbers.Remove(numbers[k]);
                                if (numbers.Count > 1)
                                {
                                    numbers.Insert(k, decreasedNumber);
                                }

                            }
                            else if (numbers[k] <= removedIndex)
                            {
                                int currentIndex = numbers[k];
                                int increasedNumber =currentIndex + removedIndex;
                                numbers.Remove(numbers[k]);
                                numbers.Insert(k, increasedNumber);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
        }
    }

