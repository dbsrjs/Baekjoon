string[] input1 = Console.ReadLine().Split();
int y1 = int.Parse(input1[0]);
int m1 = int.Parse(input1[1]);
int d1 = int.Parse(input1[2]);

string[] input2 = Console.ReadLine().Split();
int y2 = int.Parse(input2[0]);
int m2 = int.Parse(input2[1]);
int d2 = int.Parse(input2[2]);

int year1, year2, year3;

if (m1 < m2)
{
    year1 = y2 - y1;
}
else if (m1 == m2 && d1 <= d2)
{
    year1 = y2 - y1;
}
else
{
    year1 = y2 - y1 - 1;
}

year2 = y2 - y1 + 1;
year3 = y2 - y1;

Console.WriteLine(year1);
Console.WriteLine(year2);
Console.WriteLine(year3);