import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int N = scanner.nextInt();
        int M = scanner.nextInt();
        scanner.nextLine(); // 버퍼 비우기
        int result = 0;

        for (int i = 0; i < N; i++) {
            String opinion = scanner.nextLine();
            int agreeCount = 0;

            for (char c : opinion.toCharArray()) {
                if (c == 'O') agreeCount++;
            }

            if (agreeCount >= (M / 2) + 1) {
                result++;
            }
        }

        System.out.println(result);
        scanner.close();
    }
}
