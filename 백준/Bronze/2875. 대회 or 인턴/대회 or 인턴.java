import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int M = sc.nextInt();
        int K = sc.nextInt();

        int team = 0;

        while (true) {
            N -= 2;
            M -= 1;

            if (N < 0 || M < 0 || (N + M) < K)
                break;

            team++;
        }

        System.out.println(team);
        sc.close();
    }
}
