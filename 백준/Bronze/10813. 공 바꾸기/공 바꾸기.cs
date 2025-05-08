string[] strs = Console.ReadLine().Split();
int n = int.Parse(strs[0]);
int m = int.Parse(strs[1]);

int[] nums = new int[n];

for (int i = 0; i < n; i++)
{
    nums[i] = i+1;
}

for (int i = 0; i < m; i++)
{
    strs = Console.ReadLine().Split();
    int m1 = int.Parse(strs[0]);
    int m2 = int.Parse(strs[1]);

    int temp = nums[m1 - 1];
    nums[m1 - 1] = nums[m2 - 1];
    nums[m2 - 1] = temp;
}

foreach (int i in nums)
{
    Console.Write(i + " ");
}