import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while (true) {
            String[] input = sc.nextLine().split(" ");
            int len = Integer.parseInt(input[0]);
            if (len == 0) break;

            int n = 1;
            for (int i = 0; i < len; i++) {
                int sf = Integer.parseInt(input[2 * i + 1]);
                int p = Integer.parseInt(input[2 * i + 2]);
                n = n * sf - p;
            }
            System.out.println(n);
        }

        sc.close();
    }
}
