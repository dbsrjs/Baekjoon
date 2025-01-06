int cnt = int.Parse(Console.ReadLine());

for (int i = 0; i < cnt; i++)
{
    string str = Console.ReadLine();

    int first = int.Parse(str.Substring(2, 2));
    int num = int.Parse(str) + 1;

    Console.WriteLine(num %  first == 0 ? "Good" : "Bye");
}