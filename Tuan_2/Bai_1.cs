using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            Console.WriteLine("Kết quả:");
            Console.WriteLine("Giá trị x\t\tGiá trị y\t\tBiểu thức\tKết quả");
            Console.WriteLine("{0,-8}\t{1,-8}\tx=y+3 \t x={2,-8}", x, y, y + 3);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=y-2 \t x={2,-8}", x, y, y - 2);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=y*5 \t x={2,-8}", x, y, y * 5);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=x/y \t x={2,-8}", x, y, (float)x / y);
            Console.WriteLine("{0,-8}\t{1,-8}\tx=x%y \t x={2,-8}", x, y, x % y);
            Console.ReadLine();
        }
    }
}
