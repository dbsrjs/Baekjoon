 string[] inputs = Console.ReadLine().Split(' ');
int n = int.Parse(inputs[0]);
int m = int.Parse(inputs[1]);
int k = int.Parse(inputs[2]);

int ans = Math.Min(m, k) + Math.Min(n - m, n - k);
Console.WriteLine(ans);