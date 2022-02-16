using System;

namespace Bai_3___Tim_Uoc_So_Chung_Cua_Hai_So
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            NhapDuLieu(ref a, ref b);
            Console.Write("UC là: " + XetUocSoChungLonNhat2So(a, b));
        }
        static void NhapDuLieu (ref int a, ref int b)
        {
            do
            {
                Console.Write("Nhập a: ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);
            do
            {
                Console.Write("Nhập b: ");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);
        }
        static int XetUocSoChungLonNhat2So (int iSo1, int iSo2)
        {
            while (iSo1 != iSo2)
            {
                if (iSo1 > iSo2)
                {
                    iSo1 = iSo1 - iSo2;
                }
                else
                {
                    iSo2 = iSo2 - iSo1;
                }
            }
            return iSo1;
        }
    }
}
