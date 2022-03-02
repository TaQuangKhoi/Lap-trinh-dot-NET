using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            NhapN(out n);
            int[] HoTen = new string [n];
            NhapDuLieu(n, HoTen);
            XuatDuLieu(n, HoTen);
            Console.WriteLine("Max: ", TimMax(n, DanhSach))
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
        public static void NhapDuLieu(int n, string [] HoTen)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập tên {0} : ", i + 1);
                HoTen[i] = Console.ReadLine();
            }
        }
        public static int TimMax(int n, int[] DanhSach)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (DanhSach[i] < DanhSach[j])
                    {
                        max = DanhSach[i];
                    }
                }
            }
            return max;
        }
    }
}
