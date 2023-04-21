using System;
using System.Collections.Generic;

class SinhVien
{
    public string MaSV { get; set; }
    public string TenSV { get; set; }
    public double DiemTB { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<SinhVien> danhSachSV = new List<SinhVien>();

        // Nhập danh sách sinh viên
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            SinhVien sv = new SinhVien();

            Console.Write("Nhap ma so sinh vien: ");
            sv.MaSV = Console.ReadLine();

            Console.Write("Nhap ten sinh vien: ");
            sv.TenSV = Console.ReadLine();

            Console.Write("Nhap diem trung binh: ");
            sv.DiemTB = double.Parse(Console.ReadLine());

            danhSachSV.Add(sv);
        }

        // Tìm kiếm sinh viên theo mã số
        Console.Write("Nhap ma so sinh vien can tim: ");
        string maSo = Console.ReadLine();

        SinhVien svTimThay = danhSachSV.Find(sv => sv.MaSV == maSo);

        if (svTimThay == null)
        {
            Console.WriteLine("Khong tim thay sinh vien co ma so " + maSo);
        }
        else
        {
            Console.WriteLine("Thong tin sinh vien co ma so " + maSo);
            Console.WriteLine("Ten sinh vien: " + svTimThay.TenSV);
            Console.WriteLine("Diem trung binh: " + svTimThay.DiemTB);
        }

        Console.ReadKey();
    }
}
