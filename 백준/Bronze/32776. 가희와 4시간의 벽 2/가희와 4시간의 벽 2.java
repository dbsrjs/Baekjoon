import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int S = sc.nextInt();
        int Ma = sc.nextInt();
        int F = sc.nextInt();
        int Mb = sc.nextInt();

        if (S <= 240 || S <= Ma + F + Mb) {
            System.out.println("high speed rail");
        } else {
            System.out.println("flight");
        }

        sc.close();
    }
}
