using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập chuỗi ký tự: ");
        string str = Console.ReadLine();
        Console.Write("Nhập chuỗi con: ");
        string sub = Console.ReadLine();

        int count = 0;
        int i = 0;
        while (i <= str.Length - sub.Length) {
            if (str.Substring(i, sub.Length).Equals(sub)) {
                count++;
                i += sub.Length;
            } else {
                i++;
            }
        }

        Console.WriteLine("Kết quả: " + count);
        Console.ReadLine();
    }
}
