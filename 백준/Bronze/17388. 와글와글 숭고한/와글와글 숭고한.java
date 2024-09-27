import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int s = Integer.parseInt(str[0]);
        int k = Integer.parseInt(str[1]);
        int h = Integer.parseInt(str[2]);

        int sum = s + k + h;

        if (sum >= 100)
            System.out.println("OK");
        else
        {
            int min1 = Math.min(s, k);

            int min2 = Math.min(min1, h);

            if (min2 == s)
                System.out.println("Soongsil");

            else if (min2 == k)
                System.out.println("Korea");

            else if (min2 == h)
                System.out.println("Hanyang");
        }
    }
}