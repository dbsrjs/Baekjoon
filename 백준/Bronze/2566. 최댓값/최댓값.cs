namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = -1;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                for (int j = 0; j < 9; j++)
                {
                    int num = int.Parse(nums[j]);
                    if (num > max)
                    {
                        max = num;
                        x = i + 1; // Convert to 1-based index
                        y = j + 1; // Convert to 1-based index
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine($"{x} {y}");
        }
    }
}