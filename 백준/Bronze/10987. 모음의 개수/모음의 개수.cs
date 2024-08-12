 string str = Console.ReadLine();

int count = 0;

for (int i = 0; i < str.Length; i++)
{
    char t = str[i];
    
    if (t == 'a' || t == 'e' || t == 'i' || t == 'o' || t == 'u')
        ++count;
}

Console.WriteLine(count);