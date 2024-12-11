import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Map<Character, Integer> chess = new HashMap<>();
        chess.put('K', 0); chess.put('k', 0);
        chess.put('P', 1); chess.put('p', 1);
        chess.put('N', 3); chess.put('n', 3);
        chess.put('B', 3); chess.put('b', 3);
        chess.put('R', 5); chess.put('r', 5);
        chess.put('Q', 9); chess.put('q', 9);

        int white = 0, black = 0;
        Scanner sc = new Scanner(System.in);

        for (int i = 0; i < 8; i++) {
            String pieces = sc.nextLine();
            for (char p : pieces.toCharArray()) {
                if (p == '.') continue;

                if (Character.isUpperCase(p)) {
                    white += chess.get(p);
                } else {
                    black += chess.get(p);
                }
            }
        }

        System.out.println(white - black);
    }
}
