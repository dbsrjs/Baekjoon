string[] str = Console.ReadLine().Split();

int n = int.Parse(str[0]);  //학생 수
int k = int.Parse(str[1]);  //과목 수

int[] ranks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < k; i++)
{
    int P = (ranks[i] * 100) / n;

    if (P <= 4) Console.Write(1 + " ");
    else if (P <= 11) Console.Write(2 + " ");
    else if (P <= 23) Console.Write(3 + " ");
    else if (P <= 40) Console.Write(4 + " ");
    else if (P <= 60) Console.Write(5 + " ");
    else if (P <= 77) Console.Write(6 + " ");
    else if (P <= 89) Console.Write(7 + " ");
    else if (P <= 96) Console.Write(8 + " ");
    else Console.Write(9 + " ");
}