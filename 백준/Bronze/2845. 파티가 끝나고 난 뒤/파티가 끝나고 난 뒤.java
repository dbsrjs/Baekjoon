import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[1]);

        int cnt = a * b; //온 인원

        str = sc.nextLine().split(" ");



        for  (int i = 0; i < str.length; i++)
        {
            System.out.print(Integer.valueOf(str[i]) > cnt ? Integer.valueOf(str[i]) - cnt + " " : Integer.valueOf(str[i]) == cnt ? 0 + " " : "-" + (cnt - Integer.valueOf(str[i])) + " ");
        }
    }
}