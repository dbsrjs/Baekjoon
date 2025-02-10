import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        String maxSeminar = "";
        int maxCount = 0;

        for (int i = 0; i < 7; i++) {
            StringTokenizer st = new StringTokenizer(br.readLine());
            String seminar = st.nextToken();
            int count = Integer.parseInt(st.nextToken());

            if (maxCount < count) {
                maxCount = count;
                maxSeminar = seminar;
            }
        }

        sb.append(maxSeminar);
        System.out.println(sb.toString());
    }
}