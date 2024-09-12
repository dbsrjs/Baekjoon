string[] str = Console.ReadLine().Split();

double a = double.Parse(str[0]);
double b = double.Parse(str[1]);
double c = double.Parse(str[2]);

int x = (int)((a * b) / c);
int y = (int)((a / b) * c);
if (x > y)
    Console.WriteLine(x);
else
    Console.WriteLine(y);