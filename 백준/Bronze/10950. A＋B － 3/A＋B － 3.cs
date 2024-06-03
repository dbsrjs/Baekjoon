int n = Int32.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] str = Console.ReadLine().Split();
    int a = Int32.Parse(str[0]);
    int b = Int32.Parse(str[1]);

    Console.WriteLine(a + b);
}