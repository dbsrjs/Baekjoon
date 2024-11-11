import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int[] a = new int[5];
		for(int i = 0; i < 5; i++) {
			a[i] = sc.nextInt();
		}
		
		int i;
		for(i = 0; i < 5; i++) {
			int count = 0;
			for(int j = 0; j < 5; j++) {
				if(a[i] == a[j])
					count++;
			}
			if(count % 2 == 1)
				break;
		}
		System.out.println(a[i]);
		
		sc.close();
	}
}