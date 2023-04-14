using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strSoNguyen; 
            int SoNguyen; 
            string KetQua; 

            strSoNguyen = Console.ReadLine(); 
            SoNguyen = Int32.Parse(strSoNguyen); 
            KetQua = (SoNguyen % 2 == 0) ? "so chan" : "so le"; 

            Console.WriteLine("{0} la {1}", SoNguyen, KetQua); 

            Console.ReadKey();
        }
    }
}
