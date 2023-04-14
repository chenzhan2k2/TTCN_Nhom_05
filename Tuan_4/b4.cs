// See https://aka.ms/new-console-template for more information
using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap n= ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}