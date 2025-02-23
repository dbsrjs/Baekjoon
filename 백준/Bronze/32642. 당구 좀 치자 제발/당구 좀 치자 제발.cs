using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] weather = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] anger = new int[N];
        int status = 0;

        for (int i = 0; i < N; i++)
        {
            if (weather[i] == 1)
                status += 1;
            else if (weather[i] == 0)
                status -= 1;

            anger[i] = status;
        }

        long totalAnger = 0;
        foreach (int a in anger)
        {
            totalAnger += a;
        }

        Console.WriteLine(totalAnger);
    }
}
