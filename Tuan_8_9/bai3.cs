using System;
using System.IO;

namespace bai3
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMo file va hien thi noi dung file tren man hinh:");
            Console.WriteLine("------------------------------------------------\n");
            Console.Write("Nhap ten file: ");
            string nameFile = Console.ReadLine();

            StreamReader myfile;
            try
            {
                myfile = File.OpenText(nameFile);
                string line = " ";
                do
                {
                    line = myfile.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                while (line != null);
            }
            catch (Exception e)
            {
                Console.WriteLine("Xay ra loi trong khi mo file.");
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}