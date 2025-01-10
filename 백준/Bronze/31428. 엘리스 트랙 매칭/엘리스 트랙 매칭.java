import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        sc.nextLine(); // 개행 문자 처리
        String[] friends = sc.nextLine().split(" ");
        String HelloBit = sc.nextLine();

        int count = 0;
        for (String friend : friends) {
            if (friend.equals(HelloBit)) {
                count++;
            }
        }

        System.out.println(count);
    }
}
