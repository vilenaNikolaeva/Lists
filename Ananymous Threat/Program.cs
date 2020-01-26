using System;
using System.Collections.Generic;
using System.Linq;

namespace Ananymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                  .Split(" ")
                  .ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                if (command[0]=="3:1")
                {
                    break;
                }
                else if (command[0]=="merge")
                {
                    int startIndex =int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    else if (endIndex>=input.Count)
                    {
                        endIndex = input.Count - 1;
                    }
                    string merged = string.Empty;
                    for (int i = 0; i <=input.Count; i++)
                    {

                        if (i>=startIndex && i<=endIndex)
                        {
                            merged += input[i];
                        }
                    }
                    input.RemoveRange(startIndex, endIndex+1);
                    input.Insert(startIndex, merged);
                }
                else if (command[0]=="divide")
                {
                    int currentIndex = int.Parse(command[1]); //0
                    int partitions = int.Parse(command[2]); //3

                    string partitionData = input[currentIndex];
                    input.RemoveAt(currentIndex);

                    int partSize = partitionData.Length / partitions; //2
                    int reminder = partitionData.Length % partitions; //0

                    List<string> tmpData = new List<string>(); 

                    for (int i = 0; i < partitions; i++)            //3
                    {
                        string tmpString = null;                   //str.empty;

                        for (int p = 0; p < partSize; p++)         //1
                        {
                            tmpString += partitionData[(i * partSize) + p]; //0[0,1,2,3*1+1]
                        }

                        if (i == partitions - 1 && reminder != 0)
                        {
                            tmpString += partitionData.Substring(partitionData.Length - reminder);
                        }

                        tmpData.Add(tmpString);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
