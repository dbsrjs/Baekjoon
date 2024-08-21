import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner sc =new Scanner(System.in);
        int p1 = sc.nextInt(), p2 = sc.nextInt(), p3 = sc.nextInt(), p4 = sc.nextInt();
        int x = sc.nextInt(), y = sc.nextInt(), r = sc.nextInt();

        if (p1 == x) System.out.println(1);
        else if(p2 == x) System.out.println(2);
        else if (p3 == x) System.out.println(3);
        else if (p4 == x) System.out.println(4);
        else System.out.println(0);
    }
}