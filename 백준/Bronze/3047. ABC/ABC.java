import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int[] numbers = new int[3];
        for (int i = 0; i < 3; i++) {
            numbers[i] = sc.nextInt();
        }
        Arrays.sort(numbers);
        sc.nextLine();  // 개행문자 처리

        String order = sc.nextLine();
        for (char c : order.toCharArray()) {
            if (c == 'A')
                System.out.print(numbers[0] + " ");
            else if (c == 'B')
                System.out.print(numbers[1] + " ");
            else if (c == 'C')
                System.out.print(numbers[2] + " ");
        }

        sc.close();
    }
}
