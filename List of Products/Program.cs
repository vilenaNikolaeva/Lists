using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            List<string> products = new List<string>();


            for (int i = 0; i < num; i++)
            {
              string currentProducts = Console.ReadLine();
                products.Add(currentProducts);
            }
            products.Reverse();
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
