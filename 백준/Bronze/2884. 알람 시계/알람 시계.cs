string[] strs = Console.ReadLine().Split();

int h = int.Parse(strs[0]);
int m = int.Parse(strs[1]);

if (m >= 45)
{
    m -= 45;
    Console.WriteLine(h + " " + m);
}
else
{
    m += 15;
    if (h == 0)
        h = 23;
    else
        h -= 1;
    Console.WriteLine(h + " " + m);
}
return;