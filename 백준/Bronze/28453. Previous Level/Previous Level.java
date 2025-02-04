import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int ran = sc.nextInt();
        sc.nextLine();

        for (int i = 0; i < ran; i++) {
            int num = sc.nextInt();

            if(num == 300)
            {
                System.out.println("1");
            }
            else if(num >= 275)
            {
                System.out.println("2");
            }
            else if(num >=250)
            {
                System.out.println("3");
            }
            else if(num < 250)
            {
                System.out.println("4");
            }
        }
    }
}
