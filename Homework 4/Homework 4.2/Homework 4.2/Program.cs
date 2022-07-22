using System;
using System.Collections.Generic;

namespace Homework_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray;
            Console.Write("Enter your array size: ");
            sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeOfArray];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine("Your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|" + array[i]);
            }
            Console.WriteLine("|");

            Console.WriteLine("Your stack: ");
            Stack<int> stack = new Stack<int>(array);
            foreach (var item in stack)
            {
                Console.Write("|" + item);
            }
            Console.WriteLine("|");
        }
    }
}
