import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        int m = sc.nextInt();

        int[] nums = new int[n];

        for (int l = 0; l < m; l++) {
            int i = sc.nextInt();
            int j = sc.nextInt();
            int k = sc.nextInt();

            for (int h = i; h <= j; h++) {
                nums[h - 1] = k;
            }
        }

        for (int num : nums) {
            System.out.print(num + " ");
        }

        sc.close();
    }
}
