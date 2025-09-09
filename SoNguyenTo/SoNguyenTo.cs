// See https://aka.ms/new-console-template for more information
using System;
namespace MyApp
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine(n + " là số nguyên tố");
            }
            else
            {
                Console.WriteLine(n + " không phải là số nguyên tố");
            }
        }
    }
}