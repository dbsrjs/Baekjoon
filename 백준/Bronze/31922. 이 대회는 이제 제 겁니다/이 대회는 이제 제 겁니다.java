import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int A = sc.nextInt();
        int P = sc.nextInt();
        int C = sc.nextInt();
        
        System.out.println(Math.max(A + C, P));
        
        sc.close();
    }
}
