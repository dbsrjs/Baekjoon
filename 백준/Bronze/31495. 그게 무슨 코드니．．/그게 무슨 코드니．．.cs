string code = Console.ReadLine();

if (code.Length >= 2 && code[0] == '"' && code[^1] == '"')
{
    string result = code.Substring(1, code.Length - 2);
    if (result.Length > 0)
    {
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("CE");
    }
}
else
{
    Console.WriteLine("CE");
}