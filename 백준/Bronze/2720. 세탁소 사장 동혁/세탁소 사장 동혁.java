import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt(); // 테스트 케이스 개수

        int[] coins = {25, 10, 5, 1}; // Quarter, Dime, Nickel, Penny

        for (int i = 0; i < t; i++) {
            int cents = sc.nextInt(); // 센트 단위 입력 (예: 124 -> 1달러 24센트)
            int[] result = new int[4];

            for (int j = 0; j < 4; j++) {
                result[j] = cents / coins[j];
                cents %= coins[j];
            }

            System.out.printf("%d %d %d %d\n", result[0], result[1], result[2], result[3]);
        }

        sc.close();
    }
}
