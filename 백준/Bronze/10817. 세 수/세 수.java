import java.util.Scanner;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] input = scanner.nextLine().split(" ");
        int[] scores = new int[input.length];
        
        for (int i = 0; i < input.length; i++) {
            scores[i] = Integer.parseInt(input[i]);
        }
        
        Arrays.sort(scores);
        System.out.println(scores[1]);
        
        scanner.close();
    }
}