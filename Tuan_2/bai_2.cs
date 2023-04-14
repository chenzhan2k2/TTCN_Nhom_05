using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Nhập giá trị số nguyên:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Giá trị của a là {0}.", a);
            b = ++a;
            Console.WriteLine("Giá trị của ++a là {0}.", b);
            Console.WriteLine("Giá trị của a là {0}.", a);
            b = a++;
            Console.WriteLine("Giá trị của a++ là {0}.", b);
            Console.WriteLine("Giá trị của a là {0}.", a);
            b = --a;
            Console.WriteLine("Giá trị của --a là {0}.", b);
            Console.WriteLine("Giá trị của a là {0}.", a);
            b = a--;
            Console.WriteLine("Giá trị của a-- là {0}.", b);
            Console.WriteLine("Giá trị của a là {0}.", a);
            Console.ReadLine();
        }
    }
}
