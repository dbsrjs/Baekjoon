import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] min = sc.nextLine().split(" ");
        int minResult = Integer.parseInt(min[0]) + Integer.parseInt(min[1]) + Integer.parseInt(min[2]) + Integer.parseInt(min[3]);

        String[] man = sc.nextLine().split(" ");
        int manResult = Integer.parseInt(man[0]) + Integer.parseInt(man[1]) + Integer.parseInt(man[2]) + Integer.parseInt(man[3]);

        if (minResult >= manResult) {
            System.out.println(minResult);
        } else {
            System.out.println(manResult);
        }

        sc.close();
    }
}
