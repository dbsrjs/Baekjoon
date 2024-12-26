import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int res = 0;

        int t = sc.nextInt();
        int[] sub = new int[5];
        
        for (int i = 0; i < t; i++) {
            sub[i] = sc.nextInt();
        }

        if (sub[0] > sub[2]) {
            res += (sub[0] - sub[2]) * 508;
        } else {
            res += (sub[2] - sub[0]) * 108;
        }

        if (sub[1] > sub[3]) {
            res += (sub[1] - sub[3]) * 212;
        } else {
            res += (sub[3] - sub[1]) * 305;
        }

        if (sub[4] > 0) {
            res += sub[4] * 707;
        }

        res *= 4763;

        System.out.println(res);
    }
}
