using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            NhapN(out n);
            int[] DanhSach = new int[n];
            NhapDuLieu(n, DanhSach);
            XuatDuLieu(n, DanhSach);
            Console.Write("Max: " + TimMax(n, DanhSach));
            Console.Write("Min: " + TimMax(n, DanhSach));
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
        
        public static void XuatDuLieu(int n, int[] DanhSach)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan tu thu {0} là: {1}", i, DanhSach[i]);
            }
        }
        
        public static int TimMax(int n, int[] DanhSach)
        {
            int i = 0;
            int max = DanhSach[i];
            for (i = 1; i < n-1; i++)
            {
                if(max < DanhSach[i])
                {
                    max = DanhSach[i];
                }
            }
            return max;
        }
        public static int TimMin(int n, int[] DanhSach)
        {
            int i = 0;
            int max = DanhSach[i];
            for (i = 1; i < n - 1; i++)
            {
                if (max > DanhSach[i])
                {
                    max = DanhSach[i];
                }
            }
            return max;
        }
    }
}
