using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MangHoTen(); // test bt 2
            Console.ReadLine();

        }
        public static void NhapN(out int n)
        {
            //độ dài mảng
            Console.Write("Nhập độ dài mảng: ");
            n = int.Parse(Console.ReadLine());
        }
        public static void NhapDuLieu(int n, int[] DanhSach)
        {
            for (int i = 0; i < n; i++)
            {
                try {
                    Console.Write("Nhập phần tử {0} : ", i+1);
                    DanhSach[i] = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.Write("sai kieu du lieu!");
                }
                
            }
        }
        public static void NhapDuLieu(int n, String[] HoTen)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập tên {0} : ", i+1);
                HoTen[i] = Console.ReadLine();
            }
        }
        public static void XuatDuLieu(int n, int[] DanhSach)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan tu thu {0} là: {1}", i, DanhSach[i]);
            }
        }
        public static void MangHoTen() //bai tap 2: Xử lý dữ liệu họ tên
        {
            int n;
            NhapN(out n);
            String[] HoTen = new String[n];
            NhapDuLieu(n, HoTen);
            Console.WriteLine("Ban muon làm gi?")
            switch ()
        }
        public static void TachTen()
        {
            
        }
        public static void TachHoDem()
        {
            
        }
        public static void TachHo()
        {
            
        }
        public static void MangNPhanTu() //bai tap 1
        {
            int n;
            NhapN(out n);
            int[] DanhSach = new int[n];
            NhapDuLieu(n, DanhSach);
            XuatDuLieu(n, DanhSach);
        }
    }
}
