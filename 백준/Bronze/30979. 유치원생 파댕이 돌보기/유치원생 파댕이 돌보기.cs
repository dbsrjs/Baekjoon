int T = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
int[] F = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (T <= F.Sum())
{
    Console.WriteLine("Padaeng_i Happy");
}
else
{
    Console.WriteLine("Padaeng_i Cry");
}