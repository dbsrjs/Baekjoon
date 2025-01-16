 string[] inputs = Console.ReadLine().Split();
int STR = int.Parse(inputs[0]);
int DEX = int.Parse(inputs[1]);
int INT = int.Parse(inputs[2]);
int LUK = int.Parse(inputs[3]);
int N = int.Parse(inputs[4]);

int totalStatus = STR + DEX + INT + LUK;

if (totalStatus < 4 * N)
{
    Console.WriteLine((4 * N) - totalStatus);
}
else
{
    Console.WriteLine(0);
}