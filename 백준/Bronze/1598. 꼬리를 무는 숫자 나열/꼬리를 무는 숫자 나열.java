import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int a = sc.nextInt() - 1;
        int b = sc.nextInt() - 1;
        
        int result = Math.abs(a / 4 - b / 4) + Math.abs(a % 4 - b % 4);
        System.out.println(result);

        sc.close();
    }
}
