import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");

        int a = Integer.valueOf(str[0]);
        int b = Integer.valueOf(str[1]);
        int c = Integer.valueOf(str[2]);

        if((a * b) - c <= 0)
            System.out.println(0);
        else
            System.out.println((a*b) - c);
    }
}