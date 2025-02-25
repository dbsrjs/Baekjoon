int S = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split();
int Ma = int.Parse(input[0]);
int F = int.Parse(input[1]);
int Mb = int.Parse(input[2]);

if (S <= 240 || S <= Ma + F + Mb)
    Console.WriteLine("high speed rail");
else
    Console.WriteLine("flight");