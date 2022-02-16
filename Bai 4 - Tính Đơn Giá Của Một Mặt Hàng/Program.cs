using System;

namespace Bai_4___Tính_Đơn_Giá_Của_Một_Mặt_Hàng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double donGia;
            int soLuong;
            double thanhTien = 0;

            // Nhập Đơn Giá
            Console.Write("Nhập Đơn giá: ");
            donGia = double.Parse(Console.ReadLine());

            // Nhập Số Lượng
            Console.Write("Nhập Số lượng: ");
            soLuong = int.Parse(Console.ReadLine());

            // Thành Tiền trước khi giảm giá
            thanhTien = donGia * soLuong;

            // Xét điều kiện để giảm giá
            if (thanhTien > 100)
            {
                thanhTien = thanhTien - thanhTien * 0.03;
            }
            Console.Write("Thành tiền là: " + thanhTien);
        }
    }
}
