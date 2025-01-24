import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int index = sc.nextInt();
        int cnt = 0;
        sc.nextLine();
        
        for (int i = 0; i < index; i++) {
            String str = sc.nextLine();
            if (str.contains("01") || str.contains("OI")) {
                cnt++;
            }
        }
        sc.close();
        System.out.println(cnt);
    }
}
