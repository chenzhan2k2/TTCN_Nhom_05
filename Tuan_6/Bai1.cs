using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int[] arr = new int[10];
            int i;
            Console.Write("\nDoc va in cac phan mang trong C#:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap 10 phan tu mang:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nIn cac phan tu mang: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");      

            Console.ReadKey();
        } 
    }
}