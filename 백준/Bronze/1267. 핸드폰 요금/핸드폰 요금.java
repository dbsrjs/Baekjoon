import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt(); 
        int[] li = new int[N];

        for (int i = 0; i < N; i++) {
            li[i] = sc.nextInt(); 
        }

        int y = 0, m = 0;
        for (int n : li) {
            y += (n / 30 + 1) * 10;
            m += (n / 60 + 1) * 15;
        }

        if (m == y)
            System.out.println("Y M " + m);
        else if (m < y)
            System.out.println("M " + m);
        else
            System.out.println("Y " + y);
    }
}
