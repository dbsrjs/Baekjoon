int n = int.Parse(Console.ReadLine());

string[] input = Console.ReadLine().Split();
int[] scores = Array.ConvertAll(input, int.Parse); // double

Console.WriteLine(scores.Min() * scores.Max());