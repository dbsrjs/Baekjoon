String[] str = Console.ReadLine().Split();
double w = double.Parse(str[0]);
double h = double.Parse(str[1]);
double area = w * h / 2;

Console.WriteLine(area.ToString("0.0"));