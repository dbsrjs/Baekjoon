string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);    //1차원
int m = int.Parse(input[1]);    //2차원

int[,] a_Arr = new int[n, m];
int[,] b_Arr = new int[n, m];

//a
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split();
    int[] nums = Array.ConvertAll(input, int.Parse);

    for (int j = 0; j < m; j++)
    {
        a_Arr[i,j] = nums[j];
    }
}

//b
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine().Split();
    int[] nums = Array.ConvertAll(input, int.Parse);

    for (int j = 0; j < m; j++)
    {
        b_Arr[i, j] = nums[j];
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(a_Arr[i, j] + b_Arr[i, j]+" ");
    }
    Console.WriteLine();
}