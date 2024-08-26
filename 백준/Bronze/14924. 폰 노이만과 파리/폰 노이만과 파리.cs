string[] inputs = Console.ReadLine().Split(' ');
int s = int.Parse(inputs[0]);
int t = int.Parse(inputs[1]);
int d = int.Parse(inputs[2]);

// 계산 및 출력
Console.WriteLine((d / (2 * s)) * t);