import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[2]);
        int c = Integer.parseInt(str[4]);

        if(a + b == c)
            System.out.println("YES");
        else
            System.out.println("NO");
    }
}