using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int result = 0;

        for (int i = 0; i < N; i++)
        {
            string opinion = Console.ReadLine();
            int agreeCount = 0;

            foreach (char c in opinion)
            {
                if (c == 'O') agreeCount++;
            }

            if (agreeCount >= (M / 2) + 1)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}
