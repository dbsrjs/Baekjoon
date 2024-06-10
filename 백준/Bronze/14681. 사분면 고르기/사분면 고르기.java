import java.util.Scanner;

public class Main {
    public static void main(String args[]) {


        Scanner sc = new Scanner(System.in);

        int x = sc.nextInt();
        int y = sc.nextInt();

        /*
        + + : 1
        - + : 2
        - - : 3
        + - : 4
        */

        if (x > 1 && y > 1)
            System.out.println(1);
        else if (x < 1 && y > 1)
            System.out.println(2);
        else if (x < 1 && y < 1)
            System.out.println(3);
        else if (x > 1 && y < 1)
            System.out.println(4);
    }
}