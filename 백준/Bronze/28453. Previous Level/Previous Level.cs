int ran = int.Parse(Console.ReadLine());

string[] str = Console.ReadLine().Split();
int[] num = new int[ran];

for (int i = 0; i < ran; i++)
{
    num[i] = int.Parse(str[i]);

    if (num[i] == 300)
    {
        Console.Write("1 ");
    }
    else if (num[i] >= 275)
    {
        Console.Write("2 ");
    }
    else if (num[i] >= 250)
    {
        Console.Write("3 ");
    }
    else if (num[i] < 250)
    {
        Console.Write("4 ");
    }
}