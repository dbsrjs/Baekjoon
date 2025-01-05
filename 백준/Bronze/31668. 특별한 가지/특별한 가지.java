import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // 입력받기
        int N = sc.nextInt(); // 한 줄에 들어가는 파묻튀 무게
        int M = sc.nextInt(); // 전체 파묻튀 무게
        int K = sc.nextInt(); // 한 줄 바꾸는 데 필요한 가지 무게

        // 파묻튀밥 줄 수 계산
        int lines = M / N;

        // 필요한 가지 무게 계산
        int result = lines * K;

        // 결과 출력
        System.out.println(result);
    }
}
