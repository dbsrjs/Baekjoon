import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int len = sc.nextInt();
        int rs = 0, cnt = 0;
        
        sc.nextLine(); 
        String[] arr = sc.nextLine().split(" ");
        
        for (String s : arr) {
            if (s.equals("1")) 
                cnt++;
            else 
                cnt = 0;
            
            rs += cnt;
        }
        
        System.out.println(rs);
        sc.close();
    }
}
