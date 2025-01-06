import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int cnt = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < cnt; i++) {
            String str = scanner.nextLine();

            int first = Integer.parseInt(str.substring(2, 4));
            int num = Integer.parseInt(str) + 1;

            System.out.println(num % first == 0 ? "Good" : "Bye");
        }

        scanner.close();
    }
}
