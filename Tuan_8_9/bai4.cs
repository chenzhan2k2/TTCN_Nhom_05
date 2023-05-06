using System;
using System.IO;

namespace Bai4
{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            bool debug = true;

            Console.WriteLine("\nDem so lan xuat hien cua chu cai trong File:");
            Console.WriteLine("-----------------------------------------------\n");
            Console.Write("Nhap ten file: ");
            string nameFile = Console.ReadLine();
            Console.Write("Nhap chu cai can dem: ");
            string letter = Console.ReadLine();

            StreamReader myfile;
            myfile = File.OpenText(nameFile);

            string line;
            int countLetter = 0;
            do
            {
                line = myfile.ReadLine();
                if (line != null)
                    for (int i = 0; i < line.Length; i++)
                        if (line.Substring(i, 1) == letter)
                            countLetter++;
            }
            while (line != null);
            myfile.Close();

            Console.WriteLine("So lan xuat hien cua chu cai trong file la: {0}", countLetter);

            if (debug)
                Console.ReadLine();

            Console.ReadKey();
        }
    }
}