import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String code = sc.nextLine();

        if (code.length() >= 2 && code.charAt(0) == '"' && code.charAt(code.length() - 1) == '"') {
            String result = code.substring(1, code.length() - 1);
            if (!result.isEmpty()) {
                System.out.println(result);
            } else {
                System.out.println("CE");
            }
        } else {
            System.out.println("CE");
        }
    }
}
