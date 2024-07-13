import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int h = Integer.parseInt(str[0]);
        int i = Integer.parseInt(str[1]);

        int a = Integer.parseInt(str[2]);
        int r = Integer.parseInt(str[3]);
        int c = Integer.parseInt(str[4]);

        System.out.println((h*i) - (a * r * c));
    }
}