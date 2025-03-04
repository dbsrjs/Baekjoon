int N = int.Parse(Console.ReadLine()); 
int[] li = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 

int y = 0, m = 0;
foreach (int n in li)
{
    y += (n / 30 + 1) * 10;
    m += (n / 60 + 1) * 15;
}

if (m == y)
    Console.WriteLine($"Y M {m}");
else if (m < y)
    Console.WriteLine($"M {m}");
else
    Console.WriteLine($"Y {y}");
