using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int N = int.Parse(inputs[0]);
        int U = int.Parse(inputs[1]);
        int L = int.Parse(inputs[2]);
        int sign = 0;

        if (N >= 1000)
        {
            sign = 1;
        }
        else
        {
            Console.WriteLine("Bad");
        }

        if (sign == 1 && (U >= 8000 || L >= 260))
        {
            sign++;
        }

        if (sign == 1)
        {
            Console.WriteLine("Good");
        }
        else if (sign == 2)
        {
            Console.WriteLine("Very Good");
        }
    }
}
