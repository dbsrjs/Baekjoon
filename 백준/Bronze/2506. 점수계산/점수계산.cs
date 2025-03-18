int len = int.Parse(Console.ReadLine());
int rs = 0, cnt = 0;

string[] arr = Console.ReadLine().Split(' ');

foreach (string s in arr)
{
    if (s.Equals("1")) cnt++;
    else cnt = 0;

    rs += cnt;
}

Console.WriteLine(rs);