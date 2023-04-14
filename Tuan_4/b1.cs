using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}