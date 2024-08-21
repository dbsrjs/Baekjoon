string[] str = Console.ReadLine().Split();

int p1 = int.Parse(str[0]);
int p2 = int.Parse(str[1]);
int p3 = int.Parse(str[2]);
int p4 = int.Parse(str[3]);

str = Console.ReadLine().Split();

int x = int.Parse(str[0]);
int y = int.Parse(str[1]);
int r = int.Parse(str[2]);

if (p1 == x) Console.WriteLine(1);
else if(p2 == x) Console.WriteLine(2);
else if (p3 == x) Console.WriteLine(3);
else if (p4 == x) Console.WriteLine(4);
else Console.WriteLine(0);