import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String a = sc.next();
		System.out.println((int)(a.charAt(0) - 44031));
		sc.close();
	}
}