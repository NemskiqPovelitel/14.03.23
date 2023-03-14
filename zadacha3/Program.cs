using System;

namespace IntSymbol
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSymbol(n);
        }

        static void PrintSymbol(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
        }
    }
}