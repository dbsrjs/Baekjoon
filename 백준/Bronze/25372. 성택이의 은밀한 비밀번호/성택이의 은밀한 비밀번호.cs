int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    if (s.Length >= 6 && s.Length <= 9)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}