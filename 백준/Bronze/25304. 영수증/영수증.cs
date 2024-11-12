int all = int.Parse(Console.ReadLine());
int cnt = int.Parse(Console.ReadLine());

int money = 0;

for (int i = 0; i < cnt; i++)
{
    string[] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);
    money += a * b;
}

Console.WriteLine(all == money ? "Yes" : "No");
