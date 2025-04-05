string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int M = int.Parse(input[1]);

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = 0;

for (int i = 0; i < N; i++)
{
    for (int j = i + 1; j < N; j++)
    {
        for (int k = j + 1; k < N; k++)
        {
            int sum = arr[i] + arr[j] + arr[k];
            if (sum <= M)
                result = Math.Max(result, sum);
        }
    }
}

Console.WriteLine(result);