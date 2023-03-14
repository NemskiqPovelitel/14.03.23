using System;

namespace TemperatureConvert
{
    internal class Program
    {
        static void Main()
        {
            double f = double.Parse(Console.ReadLine());
            double c = FtoC(f);

            Console.WriteLine($"{c:F2}");
        }

        static double FtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}