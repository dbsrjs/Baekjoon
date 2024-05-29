int n = Int32.Parse(Console.ReadLine());

string[] name = new string[n];

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();
    name[i] = str.Substring(0,1) + str.Substring(str.Length-1);
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(name[i]);
}