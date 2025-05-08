import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        int m = sc.nextInt();

        int[] nums = new int[n];
        for (int i = 0; i < n; i++) {
            nums[i] = i + 1;
        }

        for (int i = 0; i < m; i++) {
            int m1 = sc.nextInt() - 1;
            int m2 = sc.nextInt() - 1;

            int temp = nums[m1];
            nums[m1] = nums[m2];
            nums[m2] = temp;
        }

        for (int num : nums) {
            System.out.print(num + " ");
        }

        sc.close();
    }
}
