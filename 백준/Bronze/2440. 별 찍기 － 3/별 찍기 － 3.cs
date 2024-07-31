int n = int.Parse(Console.ReadLine());

for(int i = n; i > 0; i--)
{
    for(int j = 0; j < n; j++)
        Console.Write("*");
    Console.WriteLine();
    n -= 1;
}