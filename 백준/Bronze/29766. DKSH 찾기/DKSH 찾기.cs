string word = Console.ReadLine();
int result = 0;

for (int i = 0; i < word.Length - 3; i++)
{
    if (word.Substring(i, 4) == "DKSH")
    {
        result++;
    }
}

Console.WriteLine(result);