while(true)
{
    string num = Console.ReadLine();
    int len = 2;
    len += num.Length-1;
    if (num.Equals("0")) break;

    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] == '0') len += 4;
        else if (num[i] == '1') len += 2;
        else len += 3;
    }

    Console.WriteLine(len);
}