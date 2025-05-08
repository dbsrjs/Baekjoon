int n = int.Parse(Console.ReadLine());  // 첫째 줄: 점수 개수

string[] input = Console.ReadLine().Split(); // 둘째 줄: 점수
float[] scores = Array.ConvertAll(input, float.Parse);

float mValue = scores.Max();

for (int i = 0; i < n; i++)
{
    scores[i] /= mValue * 100;
}

Console.WriteLine(scores.Average() * 10000);