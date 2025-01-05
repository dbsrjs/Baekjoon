int N = int.Parse(Console.ReadLine()); // 한 줄에 들어가는 파묻튀 무게
int M = int.Parse(Console.ReadLine()); // 전체 파묻튀 무게
int K = int.Parse(Console.ReadLine()); // 한 줄 바꾸는 데 필요한 가지 무게

// 파묻튀밥 줄 수 계산
int lines = M / N;

// 필요한 가지 무게 계산
int result = lines * K;

// 결과 출력
Console.WriteLine(result);