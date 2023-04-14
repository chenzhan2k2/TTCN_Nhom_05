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
            int a, b, c;

            a = b = (c = 9) + 1; // khởi tạo giá trị: a = 10, b = 10, c = 9
            a += b; // tương đương a = a + b
            b = c++; // thực hiện gán giá trị c cho biến b sau đó thực hiện c = c + 1
            --c; // thực hiện c = c - 1

            Console.WriteLine(" a = {0}, b = {1}, c = {2}", a, b, c);

            Console.ReadKey();
        }
    }
}
