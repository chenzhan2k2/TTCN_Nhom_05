using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập một số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        do {
            if (i % 3 == 0) {
                Console.Write(i + " ");
            }
            i++;
        } while (i <= n);

        Console.ReadLine();
    }
}
