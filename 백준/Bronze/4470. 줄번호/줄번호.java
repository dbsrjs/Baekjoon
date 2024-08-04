import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int num = sc.nextInt();
        sc.nextLine(); // 이 줄을 추가하여 남은 줄바꿈 문자를 처리합니다.

        for (int i = 0; i < num; i++) {
            String str = sc.nextLine();
            System.out.println((i + 1) + ". " + str);
        }
    }
}
