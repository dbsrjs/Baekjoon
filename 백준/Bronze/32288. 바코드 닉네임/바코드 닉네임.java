import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int len = sc.nextInt();
        String name = sc.next();
        String rs = "";

        for (int i = 0; i < name.length(); i++) {
            char c = name.charAt(i);
            if(Character.isUpperCase(c)){
                rs += Character.toLowerCase(c);
            }else{
                rs += Character.toUpperCase(c);
            }
        }

        System.out.println(rs);
    }
}
