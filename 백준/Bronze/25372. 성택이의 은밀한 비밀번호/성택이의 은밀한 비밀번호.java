import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        String[] arr = new String[N];

        for (int i = 0; i < N; i++) {
            arr[i] = sc.next();
        }

        for (int i = 0; i < N; i++) {
            if(arr[i].length() >=6 && arr[i].length() <= 9)
                System.out.println("yes");
            else
                System.out.println("no");
        }
    }
}