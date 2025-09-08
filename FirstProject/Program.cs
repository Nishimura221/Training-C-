// See https://aka.ms/new-console-template for more information
using System;
namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Output: " + sum);
        }
    }
}