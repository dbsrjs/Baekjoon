import java.io.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int burger1 = Integer.parseInt(sc.nextLine()); // 방학 기간
        int burger2 = Integer.parseInt(sc.nextLine()); // 국어 총 페이지
        int burger3 = Integer.parseInt(sc.nextLine()); // 수학 총 페이지
        int coka = Integer.parseInt(sc.nextLine()); // 국어 하루 페이지
        int sprite = Integer.parseInt(sc.nextLine()); // 수학 하루 페이지

        ArrayList<Integer> burgers = new ArrayList<>();
        burgers.add(burger1);
        burgers.add(burger2);
        burgers.add(burger3);

        ArrayList<Integer> snacks = new ArrayList<>();
        snacks.add(coka);
        snacks.add(sprite);

        Collections.sort(burgers);
        Collections.sort(snacks);

        System.out.println(burgers.get(0) + snacks.get(0) - 50);
    }
}