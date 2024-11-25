using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string jinho = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        
        List<string> mbti = new List<string>();
        for (int i = 0; i < n; i++)
        {
            mbti.Add(Console.ReadLine());
        }

        Console.WriteLine(mbti.FindAll(x => x == jinho).Count);
    }
}
