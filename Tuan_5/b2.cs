using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Nhập vào một chuỗi ký tự: ");
        string str = Console.ReadLine();
        
        int count = 0;
        int i = 0;
        do {
            count++;
            i++;
        } while (i < str.Length);
        
        Console.WriteLine("Số ký tự trong chuỗi " + str + " là " + count);
        Console.ReadLine();
    }
}
