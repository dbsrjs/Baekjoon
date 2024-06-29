import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[1]);
        int c = Integer.parseInt(str[2]);

        if (a + b == c)
            System.out.println(a + "+" + b + "=" + c);
        else if (a - b == c)
            System.out.println(a + "-" + b + "=" + c);
        else if (a * b == c)
            System.out.println(a + "*" + b + "=" + c);
        else if (a / b == c)
            System.out.println(a + "/" + b + "=" + c);
        else if (a == b + c)
            System.out.println(a + "=" + b + "+" + c);
        else if (a == b - c)
            System.out.println(a + "=" + b + "-" + c);
        else if (a == b * c)
            System.out.println(a + "=" + b + "*" + c);
        else if (a == b / c)
            System.out.println(a + "=" + b + "/" + c);
    }
}