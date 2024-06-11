import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

            String[] str = sc.nextLine().split(" ");
            double A = Double.parseDouble(str[0]);
            double B = Double.parseDouble(str[1]);
            System.out.println(A/B);
    }
}