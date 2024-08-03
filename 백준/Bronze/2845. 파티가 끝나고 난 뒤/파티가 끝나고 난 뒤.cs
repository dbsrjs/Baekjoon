string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);

int cnt = a * b; //온 인원

str = Console.ReadLine().Split();

for  (int i = 0; i < str.Length; i++)
{
    Console.Write(int.Parse(str[i]) > cnt ? int.Parse(str[i]) - cnt + " " : int.Parse(str[i]) == cnt ? 0 + " " : "-" + (cnt - int.Parse(str[i])) + " ");
}