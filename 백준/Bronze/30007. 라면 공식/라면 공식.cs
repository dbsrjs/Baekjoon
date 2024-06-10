int N = Int32.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] str = Console.ReadLine().Split();
    int A = int.Parse(str[0]);
    int B = int.Parse(str[1]);
    int X = int.Parse(str[2]);
    Console.WriteLine(A * (X - 1) + B);
}
    