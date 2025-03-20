import java.util.HashMap;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        HashMap<String, String> dic = new HashMap<>();
        dic.put("A+", "4.3"); dic.put("A0", "4.0"); dic.put("A-", "3.7");
        dic.put("B+", "3.3"); dic.put("B0", "3.0"); dic.put("B-", "2.7");
        dic.put("C+", "2.3"); dic.put("C0", "2.0"); dic.put("C-", "1.7");
        dic.put("D+", "1.3"); dic.put("D0", "1.0"); dic.put("D-", "0.7");
        dic.put("F", "0.0");

        Scanner sc = new Scanner(System.in);
        String grade = sc.next();
        sc.close();

        System.out.println(dic.get(grade));
    }
}
