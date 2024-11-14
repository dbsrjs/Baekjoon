using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int X = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        for (int i = 0; i < N; i++)
        {
            if (X % 2 == 0)
            {
                X = (X / 2) ^ 6;
            }
            else
            {
                X = (2 * X) ^ 6;
            }
        }
        
        Console.WriteLine(X);
    }
}
