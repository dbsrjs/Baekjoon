using System;

class Program
{
    static void Main()
    {
        int[] a = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        int result = 0;
        for (int i = 0; i < 5; i++)
        {
            int count = 0;
            for (int j = 0; j < 5; j++)
            {
                if (a[i] == a[j])
                    count++;
            }
            if (count % 2 == 1)
            {
                result = a[i];
                break;
            }
        }

        Console.WriteLine(result);
    }
}
