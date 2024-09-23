 int N = int.Parse(Console.ReadLine());

// 0일 때 2, 6일 때 4, 4로 나눠서 3이 나오면 3, 이 조건들이 다 안 맞으면 N % 8 출력
if (N % 8 == 0) {
    Console.WriteLine(2);
} else if (N % 4 == 3) {
    Console.WriteLine(3);
} else if (N % 8 == 6) {
    Console.WriteLine(4);
} else {
    Console.WriteLine(N % 8);
}