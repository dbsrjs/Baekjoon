import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt(); // 주어진 수
        int f = sc.nextInt(); // 나누는 수

        int result = (n / 100) * 100; // 뒤 두 자리를 00으로 만든다
        int num = 0;

        // result가 f로 나누어떨어질 때까지 증가
        while (result % f != 0) {
            result++;
            num++;
        }

        System.out.printf("%02d", num);

        sc.close();
    }
}
