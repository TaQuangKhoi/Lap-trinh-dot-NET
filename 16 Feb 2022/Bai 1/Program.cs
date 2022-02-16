using System;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cho phép in ra Tiếng Việt
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int iSoN; // Tạo biến số nguyên n
            // Yêu cầu nhập n
            Console.Write("Nhập vào số nguyên n : ");
            iSoN = int.Parse(Console.ReadLine()); // Parse để ép kiểu

            //sử dụng cấu trúc điều kiện if
            if (iSoN == 0)
            {
                Console.Write(iSoN + " là Số không âm không dương");
            }
            if (iSoN > 0)
            {
                Console.Write("Kết quả: {0} là Số dương", iSoN);
            }
            if (iSoN < 0)
            {
                Console.Write("Kết quả: {0} là Số âm", iSoN);
            }
        }
    }
}
