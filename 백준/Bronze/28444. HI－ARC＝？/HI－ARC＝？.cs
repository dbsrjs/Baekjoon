string[] str = Console.ReadLine().Split();

int h = int.Parse(str[0]);
int i = int.Parse(str[1]);

int a = int.Parse(str[2]);
int r = int.Parse(str[3]);
int c = int.Parse(str[4]);

Console.WriteLine((h*i) - (a * r * c));