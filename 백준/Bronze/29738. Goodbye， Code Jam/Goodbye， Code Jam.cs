int cnt = int.Parse(Console.ReadLine());

for (int i = 0; i < cnt; i++)
{
    int score = int.Parse(Console.ReadLine());

    if(score <= 25)
        Console.WriteLine($"Case #{i + 1}: World Finals");

    else if(score <= 1000)
        Console.WriteLine($"Case #{i + 1}: Round 3");

    else if (score <= 4500)
        Console.WriteLine($"Case #{i + 1}: Round 2");

    else
        Console.WriteLine($"Case #{i + 1}: Round 1");
}