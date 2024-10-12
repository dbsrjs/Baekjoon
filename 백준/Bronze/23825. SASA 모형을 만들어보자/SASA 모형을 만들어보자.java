import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int s = Integer.parseInt(str[0]);
        int a = Integer.parseInt(str[1]);

        int cnt = 0;

        while(s >= 2 && a >= 2)
        {
            cnt++;
            s -= 2;
            a -= 2;
        }

        System.out.println(cnt);
    }
}
