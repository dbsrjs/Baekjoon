import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[1]);
        int c = sc.nextInt();

        if ((a + b) >= (c * 2))
            System.out.println((a + b) - (c * 2));
        else
            System.out.println(a + b);
    }
}