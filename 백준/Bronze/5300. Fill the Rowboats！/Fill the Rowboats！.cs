int num = int.Parse(Console.ReadLine());
int cnt = 0;

for (int i = 1; i <= num; i++)
{
    Console.Write(i + " ");
    cnt++;
    if(cnt == 6 && i != num)
    {
        Console.Write("Go! ");
        cnt = 0;
    }
}
Console.Write("Go!");