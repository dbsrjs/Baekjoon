import java.math.BigInteger;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        BigInteger num1 = new BigInteger(sc.nextLine());
        String op = sc.nextLine();
        BigInteger num2 = new BigInteger(sc.nextLine());

        if (op.equals("+")) {
            System.out.println(num1.add(num2));
        } else if (op.equals("*")) {
            System.out.println(num1.multiply(num2));
        }
    }
}
