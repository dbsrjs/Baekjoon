import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        int a = 0, b = 0;

        for (int i = 1; i < n+1; i++) {
            a += i;
        }
        System.out.println(a);

        System.out.printf("%.0f\n", Math.pow(a, 2));

        for (int i = 1; i < n + 1; i++) {
            b += Math.pow(i, 3);
        }
        System.out.println(b);
    }
}