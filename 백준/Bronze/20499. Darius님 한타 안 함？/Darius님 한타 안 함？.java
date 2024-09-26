import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split("/");
        int K = Integer.parseInt(input[0]);
        int D = Integer.parseInt(input[1]);
        int A = Integer.parseInt(input[2]);

        if (K + A < D || D == 0) {
            System.out.println("hasu");
        } else {
            System.out.println("gosu");
        }
    }
}
