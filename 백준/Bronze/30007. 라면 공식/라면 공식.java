import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < N; i++) {
            String[] str = sc.nextLine().split(" ");
            int A = Integer.parseInt(str[0]);
            int B = Integer.parseInt(str[1]);
            int X = Integer.parseInt(str[2]);
            System.out.println(A * (X - 1) + B);
        }

        sc.close();
    }
}

/*import java.util.Scanner;

public class Main {
    public static void main(String args[]) {


        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();

        for (int i = 0; i < N; i++) {
            int A = sc.nextInt();
            int B = sc.nextInt();
            int X = sc.nextInt();

            System.out.println(A * (X - 1) + B);
        }
    }
}*/
