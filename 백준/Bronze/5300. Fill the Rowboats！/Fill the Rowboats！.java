import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        int cnt = 0;

        for (int i = 1; i <= num; i++) {
            System.out.print(i+" ");
            cnt++;
            if(cnt == 6 && i != num) {
                System.out.print("Go! ");
                cnt = 0;
            }
        }
        System.out.print("Go!");
    }
}