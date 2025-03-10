import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
		
		for(int i = 0; i < N; i++) {
			for(int j=0; j <= i; j++)
				System.out.print("*");
			for(int k=i; k < N*2-(i+2); k++)
				System.out.print(" ");
			for(int l=0; l <= i; l++)
				System.out.print("*");
			System.out.println();
		}
		
		for(int i = 1; i < N; i++) {
			for(int j=i; j < N; j++)
				System.out.print("*");
			for(int k=1; k <= i*2; k++)
				System.out.print(" ");
			for(int l=i; l < N; l++)
				System.out.print("*");
			System.out.println();
		}
		sc.close();
	}
}