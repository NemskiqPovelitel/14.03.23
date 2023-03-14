using System;

namespace LiftingPowers
{
    internal class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPowers(n, p));
        }

        static double RaiseToPowers(double n, int p)
        {
            return Math.Pow(n, p);
        }
    }
}