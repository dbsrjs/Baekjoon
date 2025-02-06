import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int T = Integer.parseInt(sc.nextLine());
        String[] arr = new String[T];

        for (int i = 0; i < T; i++) {
            arr[i] = sc.nextLine();
        }

        String result = "";

        for (int i = 0; i < arr[0].length(); i++) {
            char firstChar = arr[0].charAt(i);
            boolean isSame = true;

            for (int j = 1; j < T; j++) {
                if (arr[j].charAt(i) != firstChar) {
                    isSame = false;
                    result += "?";
                    break;
                }
            }

            if (isSame) {
                result += firstChar;
            }
        }

        System.out.println(result);
        sc.close();
    }
}
