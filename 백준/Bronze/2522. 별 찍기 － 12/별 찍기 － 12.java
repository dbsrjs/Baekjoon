import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        sc.close();

        for (int i = 1; i < a; i++) {
            String star = "*".repeat(i);
            System.out.println(String.format("%" + a + "s", star));
        }

        for (int i = a; i > 0; i--) {
            String star = "*".repeat(i);
            System.out.println(String.format("%" + a + "s", star));
        }
    }
}
