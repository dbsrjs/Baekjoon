using System;

int len = int.Parse(Console.ReadLine());
string name = Console.ReadLine();
string rs = "";

foreach (char c in name)
{
    if (char.IsUpper(c))
        rs += char.ToLower(c);
    else
        rs += char.ToUpper(c);
}

Console.WriteLine(rs);