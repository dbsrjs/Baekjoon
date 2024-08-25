string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[2]);
int c = int.Parse(str[4]);

if (a + b == c)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");