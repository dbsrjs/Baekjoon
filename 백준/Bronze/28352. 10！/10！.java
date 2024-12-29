import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        // 입력
        Scanner scanner = new Scanner(System.in);
        int N = scanner.nextInt();

        // 계산
        long res = 1;
        for (int i = 11; i <= N; i++) {
            res *= i;
        }

        // 출력
        System.out.println(6 * res);
    }
}
