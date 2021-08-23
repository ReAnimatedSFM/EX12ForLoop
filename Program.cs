using System;

namespace EX12ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1 til 9 Hello world, via *for* løkke");
            Console.WriteLine();

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i}: Hello world!");
            }
            Console.WriteLine("\nAlle lige til mellem 1 og 10");
            for (int k = 1; k <= 10; k++)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nAlle lige til mellem 1 og 10 baglæns");
            for (int c = 10; c >= 1; c--)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nAlle lige tal mellem 1 til 20");
            for (int p = 2; p <= 20; p = p + 2)
            {
                Console.Write($"{p} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nAlle ulige tal mellem 1 til 20");
            for (int j = 1; j <= 20; j = j + 2)
            {
                Console.Write($"{j} ");
            }
            Console.ReadKey();
        }
    }
}
