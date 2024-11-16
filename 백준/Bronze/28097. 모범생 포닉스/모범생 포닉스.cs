using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] studyPlan = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int totalTime = 0;

        foreach (int time in studyPlan)
        {
            totalTime += time;
        }
        totalTime += 8 * (N - 1);

        int d = totalTime / 24;
        int t = totalTime % 24;

        Console.WriteLine($"{d} {t}");
    }
}
