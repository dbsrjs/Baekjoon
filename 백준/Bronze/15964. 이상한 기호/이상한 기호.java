import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        long a = Long.parseLong(str[0]);
        long b = Long.parseLong(str[1]);

        System.out.println((a + b) * (a - b));
    }
}