import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        // 변수 선언
        int inputNum = sc.nextInt();
        sc.close();

        // 별모양 표현 (증가하는 부분)
        for (int i = 1; i <= inputNum; i++) {
            System.out.println("*".repeat(i));
        }

        // 별모양 표현 (감소하는 부분)
        for (int j = inputNum - 1; j > 0; j--) {
            System.out.println("*".repeat(j));
        }
    }
}
