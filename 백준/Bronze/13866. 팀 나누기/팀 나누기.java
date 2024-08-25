import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[1]);
        int c = Integer.parseInt(str[2]);
        int d = Integer.parseInt(str[3]);

        int team1 = Math.min(a, b) + Math.max(c, d);
        int team2 = Math.max(a, b) + Math.min(c, d);

        System.out.println(team1 >= team2 ? team1 - team2 : team2 - team1);
    }
}