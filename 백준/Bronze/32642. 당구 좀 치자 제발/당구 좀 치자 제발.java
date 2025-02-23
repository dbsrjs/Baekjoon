import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int[] weather = new int[N];
        for (int i = 0; i < N; i++) {
            weather[i] = sc.nextInt();
        }

        int[] anger = new int[N];
        int status = 0;

        for (int i = 0; i < N; i++) {
            if (weather[i] == 1)
                status += 1;
            else if (weather[i] == 0)
                status -= 1;

            anger[i] = status;
        }

        long totalAnger = 0;
        for (int a : anger) {
            totalAnger += a;
        }

        System.out.println(totalAnger);
    }
}
