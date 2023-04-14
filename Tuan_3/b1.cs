using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhập độ dài cạnh của tam giác: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine("Đây là tam giác đều.");
        }
        else
        {
            Console.WriteLine("Đây không phải là tam giác đều.");
        }
    }
}