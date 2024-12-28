import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] Global_Ponix = new String[3];
        for (int i = 0; i < 3; i++) {
            Global_Ponix[i] = sc.nextLine();
        }

        boolean l = false, k = false, p = false;

        for (String i : Global_Ponix) {
            if (i.charAt(0) == 'l')
                l = true;
            else if (i.charAt(0) == 'k')
                k = true;
            else if (i.charAt(0) == 'p')
                p = true;
        }

        if (l && k && p)
            System.out.println("GLOBAL");
        else
            System.out.println("PONIX");
    }
}
