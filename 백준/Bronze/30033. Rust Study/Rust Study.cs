int N = int.Parse(Console.ReadLine());
int cnt = 0;

string[] A = Console.ReadLine().Split();
string[] B = Console.ReadLine().Split();

for (int i = 0; i < N; i++)
{
    int a = int.Parse(A[i]);
    int b = int.Parse(B[i]);

    if (b >= a)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);