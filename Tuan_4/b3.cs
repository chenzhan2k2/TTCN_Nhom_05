using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Nhap a= ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
            Console.WriteLine(answer);
        }
    }
}
