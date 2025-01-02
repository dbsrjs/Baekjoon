import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int cnt = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < cnt; i++) {
            int score = Integer.parseInt(scanner.nextLine());

            if (score <= 25) {
                System.out.println("Case #" + (i + 1) + ": World Finals");
            } else if (score <= 1000) {
                System.out.println("Case #" + (i + 1) + ": Round 3");
            } else if (score <= 4500) {
                System.out.println("Case #" + (i + 1) + ": Round 2");
            } else {
                System.out.println("Case #" + (i + 1) + ": Round 1");
            }
        }

        scanner.close();
    }
}
