List<int> numbers = new List<int> {};

for(int i = 1; i <= 10; i++)
{
    int num = int.Parse(Console.ReadLine()) % 42;

    if(!numbers.Contains(num))
    {
        numbers.Add(num);
    }
}

Console.WriteLine(numbers.Count);