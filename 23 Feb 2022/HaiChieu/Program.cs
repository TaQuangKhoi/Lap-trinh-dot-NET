using System;

namespace HaiChieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int rong;
            NhapN(out rong, 1);
            int cao;
            NhapN(out cao, 2);
            int[,] HaiChieu = new int[rong,cao];
            NhapDuLieu(rong, cao, HaiChieu);
            XuatDuLieu(rong, cao, HaiChieu);
            Console.ReadLine();
        }
        public static void SapXep(int[,] HaiChieu)
        {

        }
        public static void NhapN(out int n, int t)
        {
            //độ dài mảng
            Console.Write("Nhap chi so {0}:", t);
            n = int.Parse(Console.ReadLine());
        }
        public static void NhapDuLieu(int rong, int cao, int[,] HaiChieu)
        {
            for (int i = 0; i < cao; i++)
            {
                for (int j = 0; j < rong; j++)
                    try
                    {
                        Console.Write("Nhập phần tử ({0},{j}) : ", i, j);
                        HaiChieu[i,j] = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.Write("sai kieu du lieu!");
                    }
            }
        }
        public static void XuatDuLieu(int rong, int cao, int[,] HaiChieu)
        {
            for (int i = 0; i < cao; i++)
            {
                for (int j = 0; j < rong; j++)
                {
                    Console.WriteLine("Phan tu ({0},{1}) là: {2}", i, j, HaiChieu[i,j]);
                }
            }
        }
    }
}
