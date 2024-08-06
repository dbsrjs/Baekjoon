int L = int.Parse(Console.ReadLine());//방학 기간
int A = int.Parse(Console.ReadLine());//국어 총 페이지
int B = int.Parse(Console.ReadLine());//수학 총 페이지
int C = int.Parse(Console.ReadLine());//국어 하루 페이지
int D = int.Parse(Console.ReadLine());//수학 하루 페이지

int cnt = 0;

while(A > 0 || B > 0)
{
    A -= C;
    B -= D;
    cnt++;
}


Console.WriteLine(L - cnt);