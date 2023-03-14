using System;

namespace FaceOfTriangle
{
    internal class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a, b);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double widht, double height)
        {
            return widht * height / 2;
        }
    }
}