import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // 입력 받기
        int N = scanner.nextInt();
        int X = scanner.nextInt();
        int[] socks = new int[N];
        for (int i = 0; i < N; i++) {
            socks[i] = scanner.nextInt();
        }

        // 가격 계산
        int minPrice = Integer.MAX_VALUE;
        for (int i = 0; i < N - 1; i++) {
            int price = (socks[i] + socks[i + 1]) * X;
            if (price < minPrice) {
                minPrice = price;
            }
        }

        // 결과 출력
        System.out.println(minPrice);
    }
}
