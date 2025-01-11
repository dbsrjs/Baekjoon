string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();

Console.WriteLine(int.Parse(a) + int.Parse(b) - int.Parse(c));

a = a + b;

Console.WriteLine(int.Parse(a) - int.Parse(c));