using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int n, i, j = 0, lon_nhat, lon_thu_hai;
            int[] arr1 = new int[50];

            Console.Write("\nTim phan tu lon thu hai trong mang C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* Nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* truoc het, chung ta tim vi tri cua phan tu lon nhat trong mang */
            lon_nhat = 0;

            for (i = 0; i < n; i++)
            {
                if (lon_nhat < arr1[i])
                {
                    lon_nhat = arr1[i];
                    j = i;
                }
            }
            /* bo qua phan tu lon nhat nay va tim phan tu lon thu hai */
            lon_thu_hai = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* bo qua phan tu lon nhat */
                    i--;
                }
                else
                {
                    if (lon_thu_hai < arr1[i])
                    {
                        lon_thu_hai = arr1[i];
                    }
                }
            }

            Console.Write("Phan tu lon thu hai trong mang la:  {0} \n\n", lon_thu_hai);       

            Console.ReadKey();
        } 
    }
}