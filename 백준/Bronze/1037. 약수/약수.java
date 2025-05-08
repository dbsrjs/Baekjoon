import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt(); // 약수의 개수
        int[] divisors = new int[n];

        for (int i = 0; i < n; i++) {
            divisors[i] = sc.nextInt();
        }

        int min = divisors[0];
        int max = divisors[0];

        for (int i = 1; i < n; i++) {
            if (divisors[i] < min) min = divisors[i];
            if (divisors[i] > max) max = divisors[i];
        }

        System.out.println(min * max);
        sc.close();
    }
}
