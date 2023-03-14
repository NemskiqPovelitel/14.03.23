using System;

namespace Receipt
{
    internal class Program
    {
        static void Main()
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("SoftUni");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}