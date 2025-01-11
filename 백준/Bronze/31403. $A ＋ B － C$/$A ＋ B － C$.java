import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String a = sc.nextLine();
        String b = sc.nextLine();
        String c = sc.nextLine();

        // 첫 번째 출력
        System.out.println(Integer.parseInt(a) + Integer.parseInt(b) - Integer.parseInt(c));

        // a에 b를 추가
        a = a + b;

        // 두 번째 출력
        System.out.println(Integer.parseInt(a) - Integer.parseInt(c));
    }
}
