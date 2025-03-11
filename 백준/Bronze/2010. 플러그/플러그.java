import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int num = sc.nextInt();
        int rs = 0;

        for (int i = 1; i <= num; i++) {
            rs += sc.nextInt();
        }
        
        rs -= (num - 1);
        System.out.println(rs);
        
        sc.close();
    }
}
