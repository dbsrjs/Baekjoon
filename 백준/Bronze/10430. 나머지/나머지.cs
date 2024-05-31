string[] str = Console.ReadLine().Split();
int A = Int32.Parse(str[0]);
int B = Int32.Parse(str[1]);
int C = Int32.Parse(str[2]);

Console.WriteLine((A + B) % C);
Console.WriteLine(((A % C) + (B % C)) % C);
Console.WriteLine((A * B) % C);
Console.WriteLine(((A % C) * (B % C)) % C);