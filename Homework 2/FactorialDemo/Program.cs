using System;

namespace FactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Enter your number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", number, Factorial(number));
        }

        static int Factorial(int number)
        {
            var factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
