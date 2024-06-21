string[] str = Console.ReadLine().Split();
int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(Console.ReadLine());

if ((a + b) >= (c * 2))
    Console.WriteLine((a + b) - (c * 2));
else
    Console.WriteLine(a + b);