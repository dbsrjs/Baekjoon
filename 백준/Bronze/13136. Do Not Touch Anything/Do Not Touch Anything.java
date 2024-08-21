import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Scanner;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) {
        Scanner sc =new Scanner(System.in);
        double R = sc.nextDouble();
        double C = sc.nextDouble();
        double N = sc.nextDouble();
        
        long RCCTV = (long) Math.ceil(R / N);
        long CCCTV = (long) Math.ceil(C / N);

        //넓이
        long CCTV = RCCTV * CCCTV;

        System.out.println(CCTV);
    }
}