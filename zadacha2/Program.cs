using System;

namespace GetMax
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int max = GetMax(n1, n2);

                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char c1 = char.Parse(Console.ReadLine());
                char c2 = char.Parse(Console.ReadLine());
                char max = GetMax(c1, c2);

                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string max = GetMax(s1, s2);

                Console.WriteLine(max);
            }
        }

        static int GetMax(int n1, int n2)
        {
            if (n1 >= n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static char GetMax(char c1, char c2)
        {
            if (c1 >= c2)
            {
                return c1;
            }
            else
            {
                return c2;
            }
        }

        static string GetMax(string s1, string s2)
        {
            if (s1.CompareTo(s2) >= 0)
            {
                return s1;
            }
            else
            {
                return s2;
            }
        }
    }
}