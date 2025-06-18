namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; //현재 기차 인원 수
            int maxCnt = 0; //최대 기차 인원 수

            for(int i = 0; i < 10; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int outCnt = int.Parse(input[0]); //내리는 인원 수
                int inCnt = int.Parse(input[1]); //타는 인원 수

                cnt -= outCnt;
                cnt += inCnt;
                if (cnt > maxCnt) //최대 기차 인원 수 갱신
                {
                    maxCnt = cnt;
                }
            }

            Console.WriteLine(maxCnt);
        }
    }
}
