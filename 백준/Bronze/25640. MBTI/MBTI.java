import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String jinho = sc.nextLine();
        int n = Integer.parseInt(sc.nextLine());

        ArrayList<String> mbti = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            mbti.add(sc.nextLine());
        }

        long count = mbti.stream().filter(m -> m.equals(jinho)).count();
        System.out.println(count);
    }
}
