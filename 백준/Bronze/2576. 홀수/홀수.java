import java.util.ArrayList;
import java.util.Scanner;
import java.util.Collections;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList<Integer> res = new ArrayList<>();

        for (int i = 0; i < 7; i++) {
            int n = sc.nextInt();
            if (n % 2 != 0)
                res.add(n);
        }
        sc.close();

        if (res.isEmpty()) {
            System.out.println(-1);
        } else {
            int sum = 0;
            for (int num : res) {
                sum += num;
            }
            System.out.println(sum);
            System.out.println(Collections.min(res));
        }
    }
}
