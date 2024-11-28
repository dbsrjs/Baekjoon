string name = Console.ReadLine();
name = name.Substring(0, 5);

int len = Convert.ToInt32(Console.ReadLine());
int cnt = 0;

for (int i = 0; i < len; i++)
{
    string a = Console.ReadLine();
    a = a.Substring(0, 5);
    if (name == a)
        cnt++;
}

Console.WriteLine(cnt);