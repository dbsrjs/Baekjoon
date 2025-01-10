int N = int.Parse(Console.ReadLine());
string[] friends = Console.ReadLine().Split();
string HelloBit = Console.ReadLine();

int count = 0;
foreach (string friend in friends)
{
    if (friend == HelloBit)
    {
        count++;
    }
}

Console.WriteLine(count);