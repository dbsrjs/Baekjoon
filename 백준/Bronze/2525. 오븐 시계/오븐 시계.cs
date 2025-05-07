using System;

class Program
{
    static void Main()
    {
        string[] strs = Console.ReadLine().Split();
        int h = int.Parse(strs[0]);
        int m = int.Parse(strs[1]);

        int num = int.Parse(Console.ReadLine());

        m += num;

        h += m / 60;
        m = m % 60;

        h = h % 24;

        Console.WriteLine($"{h} {m}");
    }
}
