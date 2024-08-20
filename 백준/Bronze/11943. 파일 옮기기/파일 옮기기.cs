//A, C : 사과
//b, D : 오렌지

string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);

str = Console.ReadLine().Split();

int c = int.Parse(str[0]);
int d = int.Parse(str[1]);

Console.WriteLine(Math.Min(a + d, b + c));