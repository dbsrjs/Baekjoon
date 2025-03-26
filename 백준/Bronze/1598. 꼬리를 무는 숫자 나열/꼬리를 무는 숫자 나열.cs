string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]) - 1;
int b = int.Parse(input[1]) - 1;

int result = Math.Abs(a / 4 - b / 4) + Math.Abs(a % 4 - b % 4);
Console.WriteLine(result);