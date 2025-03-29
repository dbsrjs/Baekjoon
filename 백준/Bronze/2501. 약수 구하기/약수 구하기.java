import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        int k = sc.nextInt();
        sc.close();

        ArrayList<Integer> divisors = new ArrayList<>();

        for (int i = 1; i <= N; i++) {
            if (N % i == 0) {
                divisors.add(i);
            }
        }

        int result = (divisors.size() < k) ? 0 : divisors.get(k - 1);
        System.out.println(result);
    }
}
