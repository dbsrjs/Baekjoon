import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int 치킨 = sc.nextInt();
        sc.nextLine();

        String[] str = sc.nextLine().split(" ");
        int 콜라 = Integer.parseInt(str[0]);
        int 맥주 = Integer.parseInt(str[1]);

        int 콜라로_치킨_수 = 콜라 / 2;

        int 만들_수_있는_치킨 = Math.min(치킨, 콜라로_치킨_수 + 맥주);

        System.out.println(만들_수_있는_치킨);
    }
}
