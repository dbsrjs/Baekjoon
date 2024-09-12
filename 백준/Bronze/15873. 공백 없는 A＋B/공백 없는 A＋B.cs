int n = int.Parse(Console.ReadLine());

if (100 > n)
    Console.WriteLine(n / 10 + n % 10);
else if (n % 10 == 0)
    Console.WriteLine(n / 100 + 10);
else
    Console.WriteLine(n % 100 + 10);