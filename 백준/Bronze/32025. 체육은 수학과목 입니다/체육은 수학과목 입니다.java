import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int H = sc.nextInt();
        int W = sc.nextInt();

        System.out.println((int)(Math.min(H, W) * 100 / 2));
        
        sc.close();
    }
}