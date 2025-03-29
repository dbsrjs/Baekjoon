string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int k = int.Parse(input[1]);

List<int> divisors = new List<int>();

for (int i = 1; i <= N; i++)
{
    if (N % i == 0)
    {
        divisors.Add(i);
    }
}

int result = (divisors.Count < k) ? 0 : divisors[k - 1];
Console.WriteLine(result);