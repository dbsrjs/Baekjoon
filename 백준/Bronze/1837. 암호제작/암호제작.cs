using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        BigInteger P = BigInteger.Parse(input[0]);
        int K = int.Parse(input[1]);

        for (int i = 2; i < K; i++)
        {
            if (P % i == 0)
            {
                Console.WriteLine("BAD " + i);
                return;
            }
        }

        Console.WriteLine("GOOD");
    }
}
