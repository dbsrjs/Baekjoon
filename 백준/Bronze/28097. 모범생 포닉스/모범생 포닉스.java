import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int[] studyPlan = new int[N];
        int totalTime = 0;

        for (int i = 0; i < N; i++) {
            studyPlan[i] = sc.nextInt();
            totalTime += studyPlan[i];
        }
        totalTime += 8 * (N - 1);

        int d = totalTime / 24;
        int t = totalTime % 24;

        System.out.println(d + " " + t);
    }
}
