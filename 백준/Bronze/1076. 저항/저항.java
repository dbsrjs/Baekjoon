import java.util.*;
import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        Map<String, Integer> colorIndex = new HashMap<>();
        colorIndex.put("black", 0);
        colorIndex.put("brown", 1);
        colorIndex.put("red", 2);
        colorIndex.put("orange", 3);
        colorIndex.put("yellow", 4);
        colorIndex.put("green", 5);
        colorIndex.put("blue", 6);
        colorIndex.put("violet", 7);
        colorIndex.put("grey", 8);
        colorIndex.put("white", 9);

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String color1 = br.readLine();
        String color2 = br.readLine();
        String color3 = br.readLine();

        int first = colorIndex.get(color1);
        int second = colorIndex.get(color2);
        int multiplier = colorIndex.get(color3);

        long result = (first * 10L + second) * (long)Math.pow(10, multiplier);
        System.out.println(result);
    }
}