using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string K = Console.ReadLine();
        int odd = 0, even = 0;

        foreach (char c in K)
        {
            if ((c - '0') % 2 != 0)
                odd++;
            else
                even++;
        }

        if (odd > even)
            Console.WriteLine(1);
        else if (odd < even)
            Console.WriteLine(0);
        else
            Console.WriteLine(-1);
    }
}
