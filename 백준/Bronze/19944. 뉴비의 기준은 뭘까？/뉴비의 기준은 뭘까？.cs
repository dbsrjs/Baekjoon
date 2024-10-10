string[] str = Console.ReadLine().Split();

int n = int.Parse(str[0]);
int m = int.Parse(str[1]);

if (m == 1 || m == 2)
    Console.WriteLine("NEWBIE!");
else if (m <= n)
    Console.WriteLine("OLDBIE!");
else
    Console.WriteLine("TLE!");