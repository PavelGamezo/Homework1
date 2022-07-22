using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray, sum = 0;

            Console.Write("Enter your number N: ");
            sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];
            Console.WriteLine("Enter your array elements: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            ShowArray(array);

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Sum of array elements with odd indices: {sum}");

            int minElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minElement > array[i])
                {
                    minElement = array[i];
                }
            }
            Console.WriteLine($"Your minimal element: {minElement}");
        }

        static void ShowArray(int[] array)
        {
            Console.WriteLine("Your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|" + array[i]);
            }
            Console.WriteLine("|");
        }
    }
}
