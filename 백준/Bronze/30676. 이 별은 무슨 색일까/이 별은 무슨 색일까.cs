using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if (620 <= n && n <= 780)
        {
            Console.WriteLine("Red");
        }
        else if (590 <= n && n < 620)
        {
            Console.WriteLine("Orange");
        }
        else if (570 <= n && n < 590)
        {
            Console.WriteLine("Yellow");
        }
        else if (495 <= n && n < 570)
        {
            Console.WriteLine("Green");
        }
        else if (450 <= n && n < 495)
        {
            Console.WriteLine("Blue");
        }
        else if (425 <= n && n < 450)
        {
            Console.WriteLine("Indigo");
        }
        else if (380 <= n && n < 425)
        {
            Console.WriteLine("Violet");
        }
    }
}