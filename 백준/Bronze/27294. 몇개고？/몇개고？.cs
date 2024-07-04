string[] str = Console.ReadLine().Split();

int T = int.Parse(str[0]);
int S = int.Parse(str[1]);

if (S == 1 || !(T >= 12 && T <= 16))
    Console.WriteLine(280);
else
    Console.WriteLine(320);