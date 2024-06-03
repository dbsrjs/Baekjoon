import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int N = sc.nextInt();
        int X = sc.nextInt();
        sc.nextLine(); //nextInt() 다음에 nextLine()을 호출할 때 남아 있는 개행문자(엔터)를 소비하기 위해 추가

        int[] arr = new int[N];

        // next() 대신 nextLine()을 사용하여 공백으로 구분된 숫자들을 한 번에 받아옴
        String[] arrays = sc.nextLine().split(" ");

        for (int i = 0; i < arr.length; i++)
        {
            arr[i] = Integer.parseInt(arrays[i]);
        }

        for (int i = 0; i < arr.length; i++) {
            if(arr[i] < X) {
                System.out.print(arr[i] + " ");
            }
        }
    }
}