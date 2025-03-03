using System;
using System.Numerics; // BigInteger 사용

class Program
{
    static void Main()
    {
        for (int t = 0; t < 3; t++)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += BigInteger.Parse(Console.ReadLine());
            }

            if (sum > 0)
                Console.WriteLine("+");
            else if (sum < 0)
                Console.WriteLine("-");
            else
                Console.WriteLine("0");
        }
    }
}
