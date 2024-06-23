import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int ax = Integer.parseInt(str[0]);
        int ay = Integer.parseInt(str[1]);
        int az = Integer.parseInt(str[2]);

        str = sc.nextLine().split(" ");
        int cx = Integer.parseInt(str[0]);
        int cy = Integer.parseInt(str[1]);
        int cz = Integer.parseInt(str[2]);

        System.out.print(cx - az + " ");
        System.out.print(cy / ay + " ");
        System.out.print(cz - ax + " ");
    }
}