using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int result = 0;

        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int w = int.Parse(inputs[0]);
            int h = int.Parse(inputs[1]);

            if (w == 136)
            {
                result += 1000;
            }
            else if (w == 142)
            {
                result += 5000;
            }
            else if (w == 148)
            {
                result += 10000;
            }
            else if (w == 154)
            {
                result += 50000;
            }
        }

        Console.WriteLine(result);
    }
}
