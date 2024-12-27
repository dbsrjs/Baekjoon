import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        
        int N = Integer.parseInt(scanner.nextLine());
        String K = scanner.nextLine();
        int odd = 0, even = 0;

        for (char c : K.toCharArray()) {
            if ((c - '0') % 2 != 0)
                odd++;
            else
                even++;
        }

        if (odd > even)
            System.out.println(1);
        else if (odd < even)
            System.out.println(0);
        else
            System.out.println(-1);
    }
}
