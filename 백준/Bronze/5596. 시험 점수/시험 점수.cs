string[] min = Console.ReadLine().Split();

int minResult = int.Parse(min[0]) + int.Parse(min[1]) + int.Parse(min[2]) + int.Parse(min[3]);

string[] man = Console.ReadLine().Split();

int manResult = int.Parse(man[0]) + int.Parse(man[1]) + int.Parse(man[2]) + int.Parse(man[3]);

if (minResult >= manResult)
{
    Console.WriteLine(minResult);
}
    
else
    Console.WriteLine(manResult);