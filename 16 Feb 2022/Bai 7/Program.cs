using System;

namespace Bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang cuu chuong 9 theo chieu doc co dang:\n");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=10; j++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            }
        }
    }
}