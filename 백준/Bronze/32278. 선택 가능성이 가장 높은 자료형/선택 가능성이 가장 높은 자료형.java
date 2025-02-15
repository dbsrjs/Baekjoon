import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        long n = sc.nextLong();
        
        if (n >= -32768 && n <= 32767)
            System.out.println("short");
        else if (n >= -2147483648L && n <= 2147483647L)
            System.out.println("int");
        else
            System.out.println("long long");
        
        sc.close();
    }
}
