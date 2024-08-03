import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String[] str = sc.nextLine().split(" ");
        int a = Integer.parseInt(str[0]);
        int b = Integer.parseInt(str[1]);
        int c = Integer.parseInt(str[2]);

        int d = sc.nextInt();

        int hour, minute, second;

        hour = (d / 3600) + a;
        d %= 3600;

        minute = (d / 60) + b;
        d %= 60;

        second = (d + c);

        if (second > 59)
        {
            second -= 60;
            minute++;
        }

        if (minute > 59)
        {
            minute -= 60;
            hour++;
        }

        hour %= 24;

        System.out.println(hour + " " + minute + " " + second);
    }
}