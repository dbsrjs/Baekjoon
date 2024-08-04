import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int A = Integer.parseInt(sc.next());
        int B = Integer.parseInt(sc.next());

        if((A + B) % 2 != 0 || A < B) {
            System.out.println(-1);
        }else {
            System.out.println(((A + B) / 2) + " " + (((A + B) / 2) - B));
        }
    }
}