import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        String str = "SciComLove";

        if (n % 2 == 0) {
            System.out.println(str);
        } else {
            String reversed = new StringBuilder(str).reverse().toString();
            System.out.println(reversed);
        }

        scanner.close();
    }
}
