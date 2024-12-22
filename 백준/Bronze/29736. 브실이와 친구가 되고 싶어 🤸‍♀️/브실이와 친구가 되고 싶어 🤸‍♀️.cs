string[] str = Console.ReadLine().Split();

int A = int.Parse(str[0]);
int B = int.Parse(str[1]);

str = Console.ReadLine().Split();
int K = int.Parse(str[0]);
int X = int.Parse(str[1]);

int people = 0;
for (int i = K-X; i < K+X+1; i++)
{
    if (i < A || i > B) continue;
    people++;
}

if (people == 0) 
    Console.WriteLine("IMPOSSIBLE");
else
    Console.WriteLine(people);