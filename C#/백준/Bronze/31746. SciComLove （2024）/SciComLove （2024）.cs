int n = int.Parse(Console.ReadLine());
string str = "SciComLove";

if (n % 2 == 0)
    Console.WriteLine(str);
else
    Console.WriteLine(str.Reverse().ToArray());