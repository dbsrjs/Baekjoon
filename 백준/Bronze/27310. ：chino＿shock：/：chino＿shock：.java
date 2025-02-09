import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String str = sc.nextLine(); // 문자열 입력 받기

        int len = str.length();
        int num = 0;

        for (int i = 0; i < len; i++) {
            if (str.charAt(i) == '_') {
                num += 5;
            }
        }

        System.out.println(num + len + 2);
        sc.close();
    }
}
