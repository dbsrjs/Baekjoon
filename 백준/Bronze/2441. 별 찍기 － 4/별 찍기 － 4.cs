int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{

    for (int j = num - i; j < num; j++)
    {

        Console.Write(" ");

    }

    for (int k = i; k < num; k++)
    {

        Console.Write("*");

    }

    Console.WriteLine();
}