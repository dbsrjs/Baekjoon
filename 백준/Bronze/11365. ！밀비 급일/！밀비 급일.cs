while (true)
{
    string s = Console.ReadLine();
    char[] sChar = s.ToCharArray();
    char[] reverse = Enumerable.Reverse(sChar).ToArray();
    if(s == "END")
    {
        break;
    }
    Console.WriteLine(reverse);
}