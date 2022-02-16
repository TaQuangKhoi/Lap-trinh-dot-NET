Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

int n;
int tich = 1;
Console.Write("Nhap vao so nguyen n :");
do
{
    n = int.Parse(Console.ReadLine());
}
while (n < 0);

// Vòng lập tính tích
for (int i = 1; i <= n; i++)
{
    tich = tich * i;
}

Console.Write("Tích la: " + tich);