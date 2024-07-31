import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        while(true) {
            String[] str = sc.nextLine().split(" ");
            String a = str[0];  //이름
            int b = Integer.parseInt(str[1]);//나이
            int c = Integer.parseInt(str[2]);//몸무게

            if(a.equals("#") && b == 0 && c == 0)
                break;

            System.out.print(a + " ");
            if(b > 17 || c>= 80)
                System.out.println("Senior");
            else
                System.out.println("Junior");
        }
    }
}