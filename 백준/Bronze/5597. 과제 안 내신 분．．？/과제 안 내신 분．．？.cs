List<int> numbers = new List<int> {};

for(int i = 1; i <= 30; i++)
{
    numbers.Add(i);
}

for (int i = 1; i <= 28; i++)
{
    int num = int.Parse(Console.ReadLine());
    if(numbers.Contains(num))
    {
        numbers.Remove(num);
    }
}

Console.WriteLine(numbers.Min());
Console.WriteLine(numbers.Max());