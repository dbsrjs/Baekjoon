import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int n = Integer.parseInt(str[0]);
        int m = Integer.parseInt(str[1]);

        if (m == 1 || m == 2)
            System.out.println("NEWBIE!");
        else if (m <= n)
            System.out.println("OLDBIE!");
        else
            System.out.println("TLE!");
    }
}
