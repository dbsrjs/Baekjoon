string[] strs = Console.ReadLine().Split();
int n = int.Parse(strs[0]);
int m = int.Parse(strs[1]);

int[] nums = new int[n];

for (int l = 0; l < m; l++)
{
    strs = Console.ReadLine().Split();
    int i = int.Parse(strs[0]);
    int j = int.Parse(strs[1]);
    int k = int.Parse(strs[2]);

    for(int h = i; h <= j; h++)
    {
        nums[h-1] = k;
    }
}

foreach (var num in nums)
{
    Console.Write(num + " ");
}