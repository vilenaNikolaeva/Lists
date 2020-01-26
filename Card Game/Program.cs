using System;
using System.Collections.Generic;
using System.Linq;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firtsPlayer = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

            List<int> secondPlayer = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();

            while (true)
            {
                if (firtsPlayer[0] > secondPlayer[0])
                {
                    firtsPlayer.Add(firtsPlayer[0]);
                    firtsPlayer.Add(secondPlayer[0]);
                }
                else if (secondPlayer[0]>firtsPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firtsPlayer[0]);
                }
                firtsPlayer.Remove(firtsPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);

                if (firtsPlayer.Count==0)
                {
                    int sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count==0)
                {
                    int sum = firtsPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
