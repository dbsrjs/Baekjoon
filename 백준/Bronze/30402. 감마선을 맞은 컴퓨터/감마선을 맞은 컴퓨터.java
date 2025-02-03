import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        for (int i = 0; i < 15; i++) {
            String[] pic = sc.nextLine().split(" ");

            for (String color : pic) {
                if (color.equals("w")) {
                    System.out.println("chunbae");
                    return;
                } else if (color.equals("b")) {
                    System.out.println("nabi");
                    return;
                } else if (color.equals("g")) {
                    System.out.println("yeongcheol");
                    return;
                }
            }
        }
    }
}
