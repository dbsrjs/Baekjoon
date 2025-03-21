import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int cases = sc.nextInt();
        int answer = 0;

        for (int i = 0; i < cases; i++) {
            int a = sc.nextInt();
            int b = sc.nextInt();
            int c = sc.nextInt();

            if (a == b && b == c) 
                answer = Math.max(answer, 10000 + a * 1000);
            else if (a == b || a == c) 
                answer = Math.max(answer, 1000 + a * 100);
            else if (b == c) 
                answer = Math.max(answer, 1000 + b * 100);
            else 
                answer = Math.max(answer, 100 * Math.max(a, Math.max(b, c)));
        }

        System.out.println(answer);
        sc.close();
    }
}
