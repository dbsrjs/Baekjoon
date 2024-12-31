import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int U = sc.nextInt();
        int L = sc.nextInt();
        int sign = 0;

        if (N >= 1000) {
            sign = 1;
        } else {
            System.out.println("Bad");
        }

        if (sign == 1 && (U >= 8000 || L >= 260)) {
            sign++;
        }

        if (sign == 1) {
            System.out.println("Good");
        } else if (sign == 2) {
            System.out.println("Very Good");
        }

        sc.close();
    }
}
