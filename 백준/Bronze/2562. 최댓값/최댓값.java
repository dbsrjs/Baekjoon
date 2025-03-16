import java.util.Scanner;

public class Main {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int array1[] = new int[9];
		int max = 0;
		int index = 0;
		
		for(int i=0;i<array1.length;i++) {
			array1[i] = sc.nextInt();
			
			if(array1[i]>max) { 
				max = array1[i]; 
				index = i+1; 
			}
		}
		sc.close();
		
		System.out.println(max);;
		System.out.println(index);
		
	}

}