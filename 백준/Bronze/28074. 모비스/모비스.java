import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String[] MOBIS = {"M", "O", "B", "I", "S"};
        Scanner scanner = new Scanner(System.in);
        String word = scanner.nextLine();
        boolean result = true;

        for (String letter : MOBIS) {
            if (!word.contains(letter)) {
                result = false;
                break;
            }
        }

        if (result) {
            System.out.println("YES");
        } else {
            System.out.println("NO");
        }
    }
}
