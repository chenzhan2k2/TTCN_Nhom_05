using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toan tu gan trong C#");
            Console.WriteLine("-----------------------");

            int a = 21;
            int c;
            c = a;
            Console.WriteLine("1 - Gia tri cua c = {0}", c);

            c += a;
            Console.WriteLine("2 - Gia tri cua c = {0}", c);

            c -= a;
            Console.WriteLine("3 - Gia tri cua c = {0}", c);

            c *= a;
            Console.WriteLine("4 - Gia tri cua c = {0}", c);

            c /= a;
            Console.WriteLine("5 - Gia tri cua c = {0}", c);

            c = 200;
            c %= a;
            Console.WriteLine("6 - Gia tri cua c = {0}", c);

            c <<= 2;
            Console.WriteLine("7 - Gia tri cua c = {0}", c);

            c >>= 2;
            Console.WriteLine("8 - Gia tri cua c = {0}", c);

            c &= 2;
            Console.WriteLine("9 - Gia tri cua c = {0}", c);

            c ^= 2;
            Console.WriteLine("10 - Gia tri cua c = {0}", c);

            c |= 2;
            Console.WriteLine("11 - Gia tri cua c = {0}", c);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
