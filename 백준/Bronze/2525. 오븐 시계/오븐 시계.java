import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int h = sc.nextInt();
        int m = sc.nextInt();
        int num = sc.nextInt();

        m += num;
        h += m / 60;
        m = m % 60;
        h = h % 24;

        System.out.println(h + " " + m);
        sc.close();
    }
}
