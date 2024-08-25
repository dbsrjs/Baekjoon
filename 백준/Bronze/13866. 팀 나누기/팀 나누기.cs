string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);
int d = int.Parse(str[3]);

int team1 = Math.Min(a, b) + Math.Max(c, d);
int team2 = Math.Max(a, b) + Math.Min(c, d);

Console.WriteLine(team1 >= team2 ? team1 - team2 : team2 - team1);