import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> x = new ArrayList<>();
        List<Integer> y = new ArrayList<>();

        for (int i = 0; i < 3; i++) {
            int a = sc.nextInt();
            int b = sc.nextInt();

            if (x.contains(a)) x.remove((Integer) a);
            else x.add(a);

            if (y.contains(b)) y.remove((Integer) b);
            else y.add(b);
        }
        sc.close();

        System.out.println(x.get(0) + " " + y.get(0));
    }
}
