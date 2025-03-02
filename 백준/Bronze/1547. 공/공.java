import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int len = sc.nextInt();
        int pos = 1;

        for (int i = 0; i < len; i++) {
            int x = sc.nextInt();
            int y = sc.nextInt();

            if (x == pos) {
                pos = y;
            } else if (y == pos) {
                pos = x;
            }
        }

        System.out.println(pos);
        sc.close();
    }
}
