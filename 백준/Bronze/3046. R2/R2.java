import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] str = sc.nextLine().split(" ");

        int R1 = Integer.valueOf(str[0]);
        int s = Integer.valueOf(str[1]);

        System.out.println(2 * s - R1);
    }
}