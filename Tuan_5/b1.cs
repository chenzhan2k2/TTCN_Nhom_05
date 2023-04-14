using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập vào số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        int i = 1;
        while (i <= n) {
            sum += i;
            i++;
        }
        
        Console.WriteLine("Tổng các số từ 1 đến " + n + " là " + sum);
        Console.ReadLine();
    }
}
