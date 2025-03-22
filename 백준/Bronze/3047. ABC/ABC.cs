int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
char[] order = Console.ReadLine().ToCharArray();

Array.Sort(numbers);

foreach (char c in order)
{
    if (c == 'A')
        Console.Write(numbers[0] + " ");
    else if (c == 'B')
        Console.Write(numbers[1] + " ");
    else if (c == 'C')
        Console.Write(numbers[2] + " ");
}