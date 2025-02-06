import java.util.*;

public class Main {
    
    // 제곱수로 나누어떨어지는지 확인하는 함수
    public static boolean isSquarefree(long num, boolean[] isSquareFree) {
        for (long i = 2; i * i <= num; i++) {
            if (num % (i * i) == 0) {
                return false; // 제곱수로 나누어떨어지면 제곱ㄴㄴ수가 아님
            }
        }
        return true; // 제곱수로 나누어떨어지지 않으면 제곱ㄴㄴ수
    }
    
    public static long countSquarefree(long min, long max) {
        // 범위 내의 수를 저장할 배열 (0이 아닌 값은 제곱ㄴㄴ수)
        boolean[] isSquareFree = new boolean[(int)(max - min + 1)];
        
        Arrays.fill(isSquareFree, true);  // 기본적으로 모든 수는 제곱ㄴㄴ수로 설정

        // 2부터 sqrt(max)까지의 제곱수를 계산하여 해당 수로 나누어지는 수를 False로 설정
        long limit = (long)Math.sqrt(max);
        
        for (long i = 2; i <= limit; i++) {
            long square = i * i;
            
            // min ~ max 범위 내에서 square로 나누어떨어지는 모든 수를 False 처리
            long start = Math.max(square, (min + square - 1) / square * square);
            for (long j = start; j <= max; j += square) {
                isSquareFree[(int)(j - min)] = false;
            }
        }

        // 제곱ㄴㄴ수 개수를 세기
        long count = 0;
        for (long i = min; i <= max; i++) {
            if (isSquareFree[(int)(i - min)]) {
                count++;
            }
        }

        return count;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // 입력 받기
        long min = scanner.nextLong();
        long max = scanner.nextLong();

        // 제곱ㄴㄴ수의 개수 출력
        System.out.println(countSquarefree(min, max));
    }
}
