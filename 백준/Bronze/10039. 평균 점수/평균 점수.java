import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int result = 0;

        for (int i = 0; i < 5; i++)
        {
            int num = sc.nextInt();
            if (num < 40)
                num = 40;
            result += num;
        }

        System.out.println(result/5);
    }
}