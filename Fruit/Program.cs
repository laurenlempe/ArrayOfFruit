﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    class Program
    {
        public enum Fruit
        {
            Apple,
            Pear,
            Strawberry,
            Blueberry,
            Banana,
            Pineapple
        }
        
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];
            string userResponse;


            for (int index = 0; index < 3; index++)
            {
                Console.Write($"Enter Fruit #{index + 1}:");
                userResponse = Console.ReadLine();
                Enum.TryParse(userResponse, out fruits[index]);
            }

            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            Console.ReadKey();

        }
    }
}
