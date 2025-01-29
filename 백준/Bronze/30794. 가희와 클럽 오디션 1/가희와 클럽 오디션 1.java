import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int lv = sc.nextInt();
        String sign = sc.next();

        if (sign.equals("miss"))
            System.out.println(0);
        else if (sign.equals("bad"))
            System.out.println(200 * lv);
        else if (sign.equals("cool"))
            System.out.println(400 * lv);
        else if (sign.equals("great"))
            System.out.println(600 * lv);
        else if (sign.equals("perfect"))
            System.out.println(1000 * lv);

        sc.close();
    }
}
