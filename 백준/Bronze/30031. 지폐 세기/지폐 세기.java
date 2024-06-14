import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.StringTokenizer;

public class Main extends Exception {
    public static void main(String[] args) throws IOException {

        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder sb = new StringBuilder();

        int num = Integer.parseInt(br.readLine());
        int money = 0;

        for (int i = 0; i < num; i++) {
            StringTokenizer st = new StringTokenizer(br.readLine());

            int garo = Integer.parseInt(st.nextToken());
            int sero = Integer.parseInt(st.nextToken());

            if (garo == 136){
                money += 1000;
            }else if(garo == 142){
                money += 5000;
            }else if(garo == 148){
                money += 10000;
            }else if(garo == 154){
                money += 50000;
            }
        }

        sb.append(money);
        System.out.println(sb.toString());
    }
}