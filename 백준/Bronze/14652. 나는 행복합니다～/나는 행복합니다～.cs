string[] inputs = Console.ReadLine().Split();
int N = int.Parse(inputs[0]);
int M = int.Parse(inputs[1]);
int K = int.Parse(inputs[2]);

int n = K / M;
int m = K % M;

Console.WriteLine($"{n} {m}");