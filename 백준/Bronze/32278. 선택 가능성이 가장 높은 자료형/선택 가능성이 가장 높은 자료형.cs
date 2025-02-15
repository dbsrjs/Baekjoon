long n = long.Parse(Console.ReadLine());

if (n >= -32768 && n <= 32767)
    Console.WriteLine("short");

else if (n >= -2147483648 && n <= 2147483647)
    Console.WriteLine("int");

else
    Console.WriteLine("long long");