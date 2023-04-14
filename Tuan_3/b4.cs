
class Program
{
    static void Main(string[] args)
    {
        float diem_cc;
        float diem_gk;
        float diem_ck;
        float diem_tb;
        Console.Write("Nhập điểm chuyên cần:");
        diem_cc = float.Parse(Console.ReadLine());
        Console.Write("Nhập điểm giữa kỳ:");
        diem_gk = float.Parse(Console.ReadLine());
        Console.Write("Nhập điểm cuối kỳ:");
        diem_ck = float.Parse(Console.ReadLine());
        diem_tb = (float)(diem_cc * 0.1 + diem_gk * 0.3 + diem_ck * 0.6);
        if (diem_tb >= 9) Console.WriteLine("Loại A");
        else if ((diem_tb >= 7) && (diem_tb < 9)) Console.WriteLine("Loại B");
        else if ((diem_tb >= 5) && (diem_tb < 7)) Console.WriteLine("Loại C");
        else if (diem_tb < 5) Console.WriteLine("Loại D");
        else Console.WriteLine("Nhập giá trị không hợp lệ");
        Console.ReadLine();
    }
}