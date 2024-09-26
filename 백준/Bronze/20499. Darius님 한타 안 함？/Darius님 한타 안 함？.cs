  string[] input = Console.ReadLine().Split('/');
int K = int.Parse(input[0]);
int D = int.Parse(input[1]);
int A = int.Parse(input[2]);

if (K + A < D || D == 0)
{
    Console.WriteLine("hasu");
}
else
{
    Console.WriteLine("gosu");
}