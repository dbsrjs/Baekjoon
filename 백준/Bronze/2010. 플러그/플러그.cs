int num = int.Parse(Console.ReadLine());
int rs = 0;

for (int i = 1; i <= num; i++)
{
    rs += int.Parse(Console.ReadLine());
}
rs -= (num - 1);
Console.WriteLine(rs);