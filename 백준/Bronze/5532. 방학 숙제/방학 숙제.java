import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int L = sc.nextInt();//방학 기간
        int A = sc.nextInt();//국어 총 페이지
        int B = sc.nextInt();//수학 총 페이지
        int C = sc.nextInt();//국어 하루 페이지
        int D = sc.nextInt();//수학 하루 페이지

        int cnt = 0;

        while(A > 0 || B > 0)
        {
            A -= C;
            B -= D;
            cnt++;
        }


        System.out.println(L - cnt);
    }
}