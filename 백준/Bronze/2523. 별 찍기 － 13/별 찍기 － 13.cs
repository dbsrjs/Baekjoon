int inputNum = int.Parse(Console.ReadLine());

// 별모양 표현 (증가하는 부분)
for (int i = 1; i <= inputNum; i++)
{
    Console.WriteLine(new string('*', i));
}

// 별모양 표현 (감소하는 부분)
for (int j = inputNum - 1; j > 0; j--)
{
    Console.WriteLine(new string('*', j));
}