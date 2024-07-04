import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");

        int T = Integer.parseInt(str[0]);
        int S = Integer.parseInt(str[1]);

        if (S == 1 || !(T >= 12 && T <= 16))
            System.out.println(280);
        else
        System.out.println(320);
    }
}