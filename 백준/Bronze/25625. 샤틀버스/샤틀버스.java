import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int x = scanner.nextInt();
        int y = scanner.nextInt();
        
        if (x > y) {
            System.out.println(x + y);
        } else {
            System.out.println(y - x);
        }
    }
}
