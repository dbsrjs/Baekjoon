import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int T = scanner.nextInt(); // 테스트 케이스 수 입력받기
        
        for (int i = 0; i < T; i++) {
            int n = scanner.nextInt(); // 숫자 입력받기
            StringBuilder result = new StringBuilder();
            
            for (int j = 0; j < n / 5; j++) {
                result.append("++++ ");
            }
            for (int j = 0; j < n % 5; j++) {
                result.append("|");
            }
            
            System.out.println(result.toString().trim());
        }
        
        scanner.close();
    }
}
