string[] input = Console.ReadLine().Split();
int A = int.Parse(input[0]);
int P = int.Parse(input[1]);
int C = int.Parse(input[2]);

Console.WriteLine(Math.Max(A + C, P));