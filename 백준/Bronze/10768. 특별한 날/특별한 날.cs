int m = int.Parse(Console.ReadLine());//월
int d = int.Parse(Console.ReadLine());//일

if (m < 2)
    Console.WriteLine("Before");
else if (m == 2)
{
    if (d < 18)
        Console.WriteLine("Before");
    else if (d > 18)
        Console.WriteLine("After");
    else
        Console.WriteLine("Special");
}
else
    Console.WriteLine("After");