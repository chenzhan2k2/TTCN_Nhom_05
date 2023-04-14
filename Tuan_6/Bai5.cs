using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int n, i, j = 0, nho_nhat, nho_thu_hai;
            int[] arr1 = new int[50];

            Console.Write("\nTim phan tu nho thu hai trong mang C#:\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao trong mang (nen nhap gia tri nho hon 99999):\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* tim vi tri cua phan tu nho nhat */
            nho_nhat = 0;
            for (i = 0; i < n; i++)
            {
                if (nho_nhat > arr1[i])
                {
                    nho_nhat = arr1[i];
                    j = i;
                }
            }

            /* bo qua phan tu nho nhat va tim phan tu nho thu hai */
            nho_thu_hai = 99999; //gan mot gia tri ban dau
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* bo qua phan tu nho nhat */
                    i--;
                }
                else
                {
                    if (nho_thu_hai > arr1[i])
                    {
                        nho_thu_hai = arr1[i];
                    }
                }
            }

            Console.Write("Phan tu nho thu hai trong mang la:  {0} \n\n", nho_thu_hai);       

            Console.ReadKey();
        } 
    }
}