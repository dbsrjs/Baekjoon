import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String num1 = sc.nextLine();
        String num2 = sc.nextLine();

        int n1 = Integer.parseInt(num1);

        System.out.println(n1 * Integer.parseInt(num2.substring(2)));
        System.out.println(n1 * Integer.parseInt(num2.substring(1, 2)));
        System.out.println(n1 * Integer.parseInt(num2.substring(0, 1)));
        System.out.println(n1 * Integer.parseInt(num2));

        sc.close();
    }
}
