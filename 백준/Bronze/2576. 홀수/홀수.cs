List<int> res = new List<int>();

for (int i = 0; i < 7; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (n % 2 != 0) 
        res.Add(n);
}

if (res.Count == 0)
    Console.WriteLine(-1);
else
{
    Console.WriteLine(res.Sum());
    Console.WriteLine(res.Min());
}