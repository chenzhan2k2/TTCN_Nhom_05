using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhập vào một năm: ");
        int year = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine($"{year} là một năm nhuận.");
        }
        else
        {
            Console.WriteLine($"{year} không phải là một năm nhuận.");
        }
    }
}
