string[] inputs = Console.ReadLine().Split();
int A = int.Parse(inputs[0]);
int B = int.Parse(inputs[1]);

inputs = Console.ReadLine().Split();
int C = int.Parse(inputs[0]);
int D = int.Parse(inputs[1]);

int sum = A + B + C + D;

int rs = (A + B - 1) % 4;
rs = (rs + C + D - 1) % 4;

Console.WriteLine(rs + 1);