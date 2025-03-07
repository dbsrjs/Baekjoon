import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            String num = sc.next();
            if (num.equals("0")) break;

            int len = 2 + (num.length() - 1);

            for (char c : num.toCharArray()) {
                if (c == '0') len += 4;
                else if (c == '1') len += 2;
                else len += 3;
            }

            System.out.println(len);
        }

        sc.close();
    }
}
