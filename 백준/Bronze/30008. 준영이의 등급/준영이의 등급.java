import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();
        int k = sc.nextInt();

        int[] ranks = new int[k];

        for (int i = 0; i < k; i++) {
            ranks[i] = sc.nextInt();
        }

        for (int i = 0; i < k; i++)
        {
            int P = (ranks[i] * 100) / n;

            if (P <= 4) System.out.print(1 + " ");
            else if (P <= 11) System.out.print(2 + " ");
            else if (P <= 23) System.out.print(3 + " ");
            else if (P <= 40) System.out.print(4 + " ");
            else if (P <= 60) System.out.print(5 + " ");
            else if (P <= 77) System.out.print(6 + " ");
            else if (P <= 89) System.out.print(7 + " ");
            else if (P <= 96) System.out.print(8 + " ");
            else System.out.print(9 + " ");
        }
    }
}
