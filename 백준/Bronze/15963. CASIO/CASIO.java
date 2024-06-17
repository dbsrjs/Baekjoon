import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        long n = Long.parseLong(str[0]);
        long m = Long.parseLong(str[1]);

        if(n == m)
            System.out.println("1");
        else
            System.out.println("0");
    }
}
