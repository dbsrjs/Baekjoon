string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

Console.WriteLine(int.Parse(num1) * int.Parse(num2.Substring(2)));
Console.WriteLine(int.Parse(num1) * int.Parse(num2.Substring(1, 1)));
Console.WriteLine(int.Parse(num1) * int.Parse(num2.Substring(0, 1)));
Console.WriteLine(int.Parse(num1) * int.Parse(num2));