while(true)
{
    string[] str = Console.ReadLine().Split();

    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);

    if (a == 0 && b == 0)
        break;

    Console.WriteLine(a + b);
}