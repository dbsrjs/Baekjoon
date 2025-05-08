import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        float[] scores = new float[n];

        float max = 0;
        for (int i = 0; i < n; i++) {
            scores[i] = sc.nextFloat();
            if (scores[i] > max) max = scores[i];
        }

        float sum = 0;
        for (int i = 0; i < n; i++) {
            sum += (scores[i] / max) * 100;
        }

        System.out.println(sum / n);

        sc.close();
    }
}
