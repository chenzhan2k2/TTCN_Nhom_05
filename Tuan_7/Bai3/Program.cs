using System;

class SinhVien
{
    public string MaSV { get; set; }
    public string TenSV { get; set; }
    public double DiemTB { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ma so sinh vien: ");
        MaSV = Console.ReadLine();

        Console.Write("Nhap ten sinh vien: ");
        TenSV = Console.ReadLine();

        Console.Write("Nhap diem trung binh: ");
        DiemTB = double.Parse(Console.ReadLine());
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Ma so sinh vien: " + MaSV);
        Console.WriteLine("Ten sinh vien: " + TenSV);
        Console.WriteLine("Diem trung binh: " + DiemTB);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SinhVien sv = new SinhVien();
        sv.NhapThongTin();
        Console.WriteLine("\nThong tin sinh vien vua nhap:");
        sv.XuatThongTin();

        Console.ReadKey();
    }
}
