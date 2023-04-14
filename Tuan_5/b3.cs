using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập vào số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Các số từ 1 đến " + n + " chia hết cho 3 là:");
        int i = 1;
        while (i <= n) {
            if (i % 3 == 0) {
                Console.Write(i + " ");
            }
            i++;
        }
        
        Console.ReadLine();
    }
}
