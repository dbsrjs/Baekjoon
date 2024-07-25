int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string s = Console.ReadLine();

    if (s == "Algorithm")
        Console.WriteLine(204);
    else if (s == "DataAnalysis")
        Console.WriteLine(207);
    else if (s == "ArtificialIntelligence")
        Console.WriteLine(302);
    else if (s == "CyberSecurity")
        Console.WriteLine("B101");
    else if (s == "Network")
        Console.WriteLine("303");
    else if (s == "Startup")
        Console.WriteLine("501");
    else if (s == "TestStrategy")
        Console.WriteLine("105");
}