int[] NM = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = NM[0];
int M = NM[1];

string[] goldFishbread = new string[N];

for (int i = 0; i < N; i++)
{
    goldFishbread[i] = Console.ReadLine();
}

foreach (string eaten in goldFishbread)
{
    string reversed = new string(eaten.Reverse().ToArray());
    Console.WriteLine(reversed);
}