using System;

public class Program
{
    public static void Main(string[] args)
    {
        int total = 0;

        for (int i = 0; i < 10; i++)
        {
            int a = int.Parse(Console.ReadLine());
            total += a;
        }

        if (total % 4 == 0)
        {
            Console.WriteLine("N");
        }
        else if (total % 4 == 1)
        {
            Console.WriteLine("E");
        }
        else if (total % 4 == 2)
        {
            Console.WriteLine("S");
        }
        else if (total % 4 == 3)
        {
            Console.WriteLine("W");
        }
    }
}
