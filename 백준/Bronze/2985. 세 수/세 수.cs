string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);

if (a + b == c)
    Console.WriteLine(a + "+" + b + "=" + c);
else if (a - b == c)
    Console.WriteLine(a + "-" + b + "=" + c);
else if (a * b == c)
    Console.WriteLine(a + "*" + b + "=" + c);
else if (a / b == c)
    Console.WriteLine(a + "/" + b + "=" + c);
else if (a == b + c)
    Console.WriteLine(a + "=" + b + "+" + c);
else if (a == b - c)
    Console.WriteLine(a + "=" + b + "-" + c);
else if (a == b * c)
    Console.WriteLine(a + "=" + b + "*" + c);
else if (a == b / c)
    Console.WriteLine(a + "=" + b + "/" + c);