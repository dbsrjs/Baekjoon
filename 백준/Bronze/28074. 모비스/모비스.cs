string[] MOBIS = { "M", "O", "B", "I", "S" };
string word = Console.ReadLine();
bool result = true;

foreach (string letter in MOBIS)
{
    if (!word.Contains(letter))
    {
        result = false;
        break;
    }
}

if (result)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}