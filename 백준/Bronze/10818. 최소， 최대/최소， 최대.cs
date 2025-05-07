int cnt = int.Parse(Console.ReadLine());
int min = 1000000;
int max = -1000000;

string[] str = Console.ReadLine().Split();
int[] nums = new int[cnt];

for (int i = 0; i < cnt; i++)
{
    nums[i] = int.Parse(str[i]);
}

for (int i = 0; i < cnt; i++)
{
    if(max < nums[i]) max = nums[i];
    if(min > nums[i]) min = nums[i];
}

Console.WriteLine(min + " " + max);