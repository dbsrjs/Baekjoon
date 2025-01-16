import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int STR = sc.nextInt();
        int DEX = sc.nextInt();
        int INT = sc.nextInt();
        int LUK = sc.nextInt();
        int N = sc.nextInt();

        int totalStatus = STR + DEX + INT + LUK;

        if (totalStatus < 4 * N) {
            System.out.println((4 * N) - totalStatus);
        } else {
            System.out.println(0);
        }
    }
}
