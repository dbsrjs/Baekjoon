import java.util.HashSet;
import java.util.Scanner;
import java.util.Set;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Set<Integer> numbers = new HashSet<>();

        for (int i = 0; i < 10; i++) {
            int num = sc.nextInt() % 42;
            numbers.add(num);  // HashSet은 중복 허용 X
        }

        System.out.println(numbers.size());
        sc.close();
    }
}
