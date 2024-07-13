import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        String s = sc.next();

        if (s.equals("M"))
            System.out.println("MatKor");
        else if(s.equals("W"))
            System.out.println("WiCys");
        else if (s.equals("C"))
            System.out.println("CyKor");
        else if (s.equals("A"))
            System.out.println("AlKor");
        else if (s.equals("$"))
            System.out.println("$clear");
    }
}