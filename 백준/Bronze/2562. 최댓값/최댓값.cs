int[] array1 = new int[9];
int max = 0, index = 0;

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = int.Parse(Console.ReadLine());

    if (array1[i] > max)
    {
        max = array1[i];
        index = i + 1;
    }
}

Console.WriteLine(max);
Console.WriteLine(index);