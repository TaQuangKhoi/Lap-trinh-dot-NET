using System;

namespace Bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soDienTieuThu; double thanhTien = 0;
            Console.Write("Moi nhap so luong dien tieu thu: ");
            soDienTieuThu = int.Parse(Console.ReadLine());
            if (soDienTieuThu <= 100)
            {
            thanhTien += soDienTieuThu * 5;
            }
            else if (soDienTieuThu <=150)
            {
            thanhTien += 100 * 5 + (soDienTieuThu- 100) * 7;
            }
            else if (soDienTieuThu <=200)
            {
            thanhTien += 100 * 5 + 50 * 7+ (soDienTieuThu-150) * 10;
            }
            else if (soDienTieuThu <= 300)
            {
            thanhTien += 100 * 5 + 50 * 7 + 50 * 10 + (soDienTieuThu-200) * 15;
            }
            else
            {
            //Nếu vượt kế hoạch (300 Kwh) thực hiện như sau:
            thanhTien += 100 * 5 + 50 * 7 + 50 * 10 + 100 * 15 +
            (soDienTieuThu- 300) * 20;
            }
            Console.WriteLine("So tien ban phai tra la: " + thanhTien);
        }
    }
}
