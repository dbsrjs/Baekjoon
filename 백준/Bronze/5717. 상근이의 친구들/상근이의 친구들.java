import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while(true)
        {
            String[] str = sc.nextLine().split(" ");

            int a = Integer.valueOf(str[0]);
            int b = Integer.valueOf(str[1]);

            if (a == 0 && b == 0)
                break;

            System.out.println(a + b);
        }
    }
}