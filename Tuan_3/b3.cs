class Program
{
    static void Main(string[] args)
    {
        int x, y, z;
        Console.Write("Nhập giá trị 1:");
        x = int.Parse(Console.ReadLine());
        Console.Write("Nhập giá trị 2:");
        y = int.Parse(Console.ReadLine());
        Console.Write("Nhập giá trị 3:");
        z = int.Parse(Console.ReadLine());
        if (x > y)
            if (x > z) Console.Write("Giá trị lớn nhất là:{0}.", x);
            else Console.Write("Giá trị lớn nhất là:{0}.", z);
        else if (y > z) Console.Write("Giá trị lớn nhất là:{0}.", y);
        else Console.Write("Giá trị lớn nhất là:{0}.", z);
        Console.ReadLine();
    }
}
