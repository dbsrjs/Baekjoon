string[] str = Console.ReadLine().Split();

int A = int.Parse(str[0]);
int B = int.Parse(str[1]);

if ((A + B) % 2 != 0 || A < B)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(((A + B) / 2) + " " + (((A + B) / 2) - B));
}