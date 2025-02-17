import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int A = sc.nextInt();
        int B = sc.nextInt();
        
        int x = 1, y = 1;

        while (N > 0) {
            // 1번 조건
            x += A;
            y += B;

            // 2번 조건
            if (x < y) {
                int temp = x;
                x = y;
                y = temp;
            }

            // 3번 조건
            if (x == y)
                y -= 1;

            N--;
        }

        System.out.println(x + " " + y);
    }
}
