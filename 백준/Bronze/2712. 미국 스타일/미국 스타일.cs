 int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    double a = double.Parse(input[0]);
    string tp = input[1];

    if (tp == "kg")
        Console.WriteLine($"{a * 2.2046:F4} lb");
    else if (tp == "g")
        Console.WriteLine($"{a * 3.7854:F4} l");
    else if (tp == "l")
        Console.WriteLine($"{a * 0.2642:F4} g");
    else if (tp == "lb")
        Console.WriteLine($"{a * 0.4536:F4} kg");
}