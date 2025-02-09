string str = Console.ReadLine();

int len = str.Length;
int num = 0;

for (int i = 0; i < len; i++)
{
    if (str[i] == '_')
        num += 5;
}

Console.WriteLine(num + len + 2);