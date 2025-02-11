import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String[] input = sc.nextLine().split(" ");
        int N = Integer.parseInt(input[0]); // 버스 개수
        int X = Integer.parseInt(input[1]); // 학교까지 걸리는 시간
        
        int maxStart = -1;

        for (int i = 0; i < N; i++) {
            input = sc.nextLine().split(" ");
            int S = Integer.parseInt(input[0]); // 도착까지 남은 시간
            int T = Integer.parseInt(input[1]); // 학교까지 걸리는 시간

            if (S + T <= X && maxStart < S) {
                maxStart = S;
            }
        }

        System.out.println(maxStart);
        sc.close();
    }
}
