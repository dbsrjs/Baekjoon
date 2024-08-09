string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);

double square = Math.Pow(10, (b - a) / 400.0);

Console.WriteLine(1 / (1 + square));