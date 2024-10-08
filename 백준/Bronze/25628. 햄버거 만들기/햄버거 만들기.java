import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main extends Exception {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();
        StringTokenizer st = new StringTokenizer(br.readLine());

        int bread = Integer.parseInt(st.nextToken());
        int patty = Integer.parseInt(st.nextToken());
        int answer = Math.min((bread/2), patty);

        sb.append(answer);
        System.out.println(sb.toString());


    }
}