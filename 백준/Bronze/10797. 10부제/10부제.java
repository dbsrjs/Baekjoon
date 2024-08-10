import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int num = sc.nextInt();

        int a = sc.nextInt();
        int b = sc.nextInt();
        int c = sc.nextInt();
        int d = sc.nextInt();
        int e = sc.nextInt();

        int cnt = 0;

        if (a == num)
            cnt += 1;
        if (b == num)
            cnt += 1;
        if (c == num)
            cnt += 1;
        if (d == num)
            cnt += 1;
        if (e == num)
            cnt += 1;

        System.out.println(cnt);
    }
}