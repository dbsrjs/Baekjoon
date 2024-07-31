import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while(true) {

            String s = sc.nextLine().toUpperCase();
            int count = 0;


            if(s.equals("#")) break;

            for(int i = 0; i < s.length(); i++) {

                char ch = s.charAt(i);
                if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') {
                    count++;
                }
            }
            System.out.println(count);
        }
    }
}