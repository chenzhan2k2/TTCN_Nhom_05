using System;
using System.IO;

namespace bai2

{
    class TestCsharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nChuong trinh ghi file trong C#");
            Console.WriteLine("-----------------------------\n");
            StreamWriter myFile = File.AppendText("file.txt");
            string line;

            do
            {
                Console.Write("Nhap mot cau text: ");
                line = Console.ReadLine();

                if (line != "")
                    myFile.WriteLine(line);
            }
            while (line != "");

            myFile.Close();

            Console.ReadKey();
        }
    }
}