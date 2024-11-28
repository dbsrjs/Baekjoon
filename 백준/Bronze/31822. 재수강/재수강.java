import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String name = sc.next();
        name = name.substring(0, 5);
        int len = sc.nextInt();
        int cnt = 0;

        for(int i = 0; i < len; i++) {
            String a = sc.next();
            a = a.substring(0,5);
            if(name.equals(a))
                cnt++;
        }

        System.out.println(cnt);
    }
}
