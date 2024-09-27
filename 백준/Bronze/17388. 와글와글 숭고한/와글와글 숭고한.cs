string[] str = Console.ReadLine().Split();

int s = int.Parse(str[0]);
int k = int.Parse(str[1]);
int h = int.Parse(str[2]);

int sum = s + k + h;

if (sum >= 100)
    Console.WriteLine("OK");
else
{
    int min1 = Math.Min(s, k);

    int min2 = Math.Min(min1, h);

    if (min2 == s)
        Console.WriteLine("Soongsil");

    else if (min2 == k)
        Console.WriteLine("Korea");

    else if (min2 == h)
        Console.WriteLine("Hanyang");
}