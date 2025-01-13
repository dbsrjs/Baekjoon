import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int cnt = Integer.parseInt(sc.nextLine()); // 입력 개수

        for (int i = 0; i < cnt; i++) {
            String str = sc.nextLine();

            if (str.contains("S")) { // "S"가 포함되어 있는지 확인
                System.out.println(str);
            }
        }
    }
}
