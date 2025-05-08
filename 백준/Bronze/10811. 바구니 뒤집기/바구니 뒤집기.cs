string[] strs = Console.ReadLine().Split();
int n = int.Parse(strs[0]);
int m = int.Parse(strs[1]);

int[] nums = new int[n];

for (int i = 0; i < n; i++)
{
    nums[i] = i + 1;
}

for (int i = 0; i < m; i++)
{
    strs = Console.ReadLine().Split();
    int m1 = int.Parse(strs[0]);
    int m2 = int.Parse(strs[1]);

    // m1~m2 범위를 뒤집는다 (1-based index → 0-based index 보정)
    int left = m1 - 1;
    int right = m2 - 1;

    while (left < right)
    {
        int temp = nums[left];
        nums[left] = nums[right];
        nums[right] = temp;
        left++;
        right--;
    }
}

foreach (int i in nums)
{
    Console.Write(i + " ");
}