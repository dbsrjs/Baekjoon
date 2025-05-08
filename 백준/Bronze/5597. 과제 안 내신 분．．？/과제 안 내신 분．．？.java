import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        List<Integer> numbers = new ArrayList<>();
        for (int i = 1; i <= 30; i++) {
            numbers.add(i);
        }

        for (int i = 0; i < 28; i++) {
            int num = sc.nextInt();
            numbers.remove(Integer.valueOf(num));
        }

        Collections.sort(numbers);
        System.out.println(numbers.get(0));
        System.out.println(numbers.get(1));

        sc.close();
    }
}
