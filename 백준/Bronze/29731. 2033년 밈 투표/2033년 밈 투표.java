import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        List<String> list = new ArrayList<>();
        list.add("Never gonna give you up");
        list.add("Never gonna let you down");
        list.add("Never gonna run around and desert you");
        list.add("Never gonna make you cry");
        list.add("Never gonna say goodbye");
        list.add("Never gonna tell a lie and hurt you");
        list.add("Never gonna stop");

        int cnt = 0;

        Scanner scanner = new Scanner(System.in);
        int input = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < input; i++) {
            String str = scanner.nextLine();

            if (list.contains(str))
                cnt++;
        }

        if (cnt == input)
            System.out.println("No");
        else
            System.out.println("Yes");

        scanner.close();
    }
}
