List<int> x = new List<int>();
List<int> y = new List<int>();

for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split();
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    if (x.Contains(a)) x.Remove(a);
    else x.Add(a);

    if (y.Contains(b)) y.Remove(b);
    else y.Add(b);
}

Console.WriteLine($"{x[0]} {y[0]}");