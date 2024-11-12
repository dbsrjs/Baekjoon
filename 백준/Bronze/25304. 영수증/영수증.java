import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int all = sc.nextInt();
        int cnt = sc.nextInt();
        sc.nextLine();

        int money = 0;

        for (int i = 0; i < cnt; i++) {
            String[] str = sc.nextLine().split(" ");
            int a = Integer.parseInt(str[0]);
            int b = Integer.parseInt(str[1]);
            money += a*b;
        }

        System.out.println(all == money ? "Yes" : "No");
    }
}
