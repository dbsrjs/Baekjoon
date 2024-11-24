using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        while (T > 0)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
            T--;
        }
    }
}
