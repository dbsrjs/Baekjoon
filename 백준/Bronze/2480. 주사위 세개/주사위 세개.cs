string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);

if (a == b && b == c)
     Console.WriteLine(10000 + a * 1000);
else if (a == b || a == c)
    Console.WriteLine(1000 + a * 100);
else if (b == c)
    Console.WriteLine(1000 + b * 100);
else
    Console.WriteLine((Math.Max(Math.Max(a, b), c) * 100));