int len = int.Parse(Console.ReadLine());

for (int i = 0; i < len; i++)
{
    int rs = 0;
    string[] str = Console.ReadLine().Split();

    int sizeA = int.Parse(str[0]);
    int sizeB = int.Parse(str[1]);

    int[] lisA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int[] lisB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Array.Sort(lisB);

    foreach (var num in lisA)
    {
        foreach (var value in lisB)
        {
            if (num > value) rs++; 
            else break;
        }
    }

    Console.WriteLine(rs);
}