while(true)
{
    string[] str = Console.ReadLine().Split();

    string a = str[0];//이름
    int b = int.Parse(str[1]);//나이
    int c = int.Parse(str[2]);//몸무게

    if (a.Equals("#") && b == 0 && c == 0)
        break;

    Console.Write(a + " ");
    if (b > 17 || c >= 80)
        Console.WriteLine("Senior");
            else
        Console.WriteLine("Junior");
}