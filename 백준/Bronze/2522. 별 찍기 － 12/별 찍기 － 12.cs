 int a = int.Parse(Console.ReadLine());

for (int i = 1; i < a; i++)
{
    string star = new string('*', i);
    Console.WriteLine(star.PadLeft(a));
}

for (int i = a; i > 0; i--)
{
    string star = new string('*', i);
    Console.WriteLine(star.PadLeft(a));
}