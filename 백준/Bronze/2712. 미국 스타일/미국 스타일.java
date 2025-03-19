import java.util.*;

public class Main {
    public static void main(String[] args)  {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i < n; i++) {
            Double a = sc.nextDouble();
            String tp = sc.next();
            if(tp.equals("kg")) {
                System.out.printf("%.04f lb\n", a * 2.2046);
            }else if(tp.equals("g")) {
                System.out.printf("%.04f l\n", a * 3.7854);
            }else if(tp.equals("l")) {
                System.out.printf("%.04f g\n", a * 0.2642);
            }else if(tp.equals("lb")) {
                System.out.printf("%.04f kg\n", a * 0.4536);
            }
        }
    }
}

