import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int cnt = 0;

        try {
            while (sc.hasNextLine()) { // 입력이 존재할 때까지 반복
                sc.nextLine(); // 입력을 읽고 버림
                cnt++;
            }
        } catch (Exception e) {
            System.out.println(cnt);
        } finally {
            sc.close();
        }

        System.out.println(cnt);
    }
}
