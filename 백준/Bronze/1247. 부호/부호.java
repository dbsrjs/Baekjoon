import java.math.BigInteger;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        for (int t = 0; t < 3; t++) {
            int n = sc.nextInt();

            BigInteger s = BigInteger.ZERO;
            for (int i = 0; i < n; i++) {
                s = s.add(sc.nextBigInteger());
            }

            if (s.compareTo(BigInteger.ZERO) > 0) {
                System.out.println("+");
            } else if (s.compareTo(BigInteger.ZERO) < 0) {
                System.out.println("-");
            } else {
                System.out.println("0");
            }
        }
        sc.close();
    }
}