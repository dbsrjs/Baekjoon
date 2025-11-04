import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int count = 0;

        for (int i = 0; i < 8; i++) { // 8줄 입력
            String line = sc.nextLine();

            for (int j = 0; j < 8; j++) { // 각 문자 확인
                if ((i + j) % 2 == 0 && line.charAt(j) == 'F') {
                    count++;
                }
            }
        }

        System.out.println(count);
    }
}
