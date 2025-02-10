using System;

class Program
{
    static void Main()
    {
        string maxSeminar = "";
        int maxCount = 0;

        for (int i = 0; i < 7; i++)
        {
            string[] input = Console.ReadLine().Split();
            string seminar = input[0];
            int count = int.Parse(input[1]);

            if (maxCount < count)
            {
                maxCount = count;
                maxSeminar = seminar;
            }
        }

        Console.WriteLine(maxSeminar);
    }
}
