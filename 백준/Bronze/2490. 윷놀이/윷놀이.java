import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        for (int i = 0; i < 3; i++) {
            int zeroCount = 0;
            for (int j = 0; j < 4; j++) {
                int n = sc.nextInt();
                if (n == 0) zeroCount++;
            }

            switch (zeroCount) {
                case 1:
                    System.out.println("A");
                    break;
                case 2:
                    System.out.println("B");
                    break;
                case 3:
                    System.out.println("C");
                    break;
                case 4:
                    System.out.println("D");
                    break;
                default:
                    System.out.println("E");
                    break;
            }
        }

        sc.close();
    }
}
