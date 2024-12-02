import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int x = 0;
        int y = 0;
        int cntX = 0;
        int cntY = 0;

        int len = Integer.parseInt(sc.nextLine());

        for (int i = 0; i < len; i++) {
            if (cntX == 2 || cntY == 2)
                break;

            String str = sc.nextLine();
            if (str.equals("D")) {
                cntY--;
                x++;
                cntX++;
            } else if (str.equals("P")) {
                cntX--;
                y++;
                cntY++;
            }
        }

        System.out.println(x + ":" + y);
    }
}
