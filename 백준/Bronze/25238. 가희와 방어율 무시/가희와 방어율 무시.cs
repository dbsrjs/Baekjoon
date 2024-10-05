string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);

double tmp = a - a * (1d * b / 100);

Console.WriteLine(tmp >= 100 ? 0 : 1);