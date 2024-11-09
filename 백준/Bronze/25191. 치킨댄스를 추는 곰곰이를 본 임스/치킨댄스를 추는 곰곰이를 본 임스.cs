int 치킨 = int.Parse(Console.ReadLine());

string[] str = Console.ReadLine().Split();

int 콜라 = int.Parse(str[0]);
int 맥주 = int.Parse(str[1]);

int 콜라로_치킨_수 = 콜라 / 2;

int 만들_수_있는_치킨 = Math.Min(치킨, 콜라로_치킨_수 + 맥주);

Console.WriteLine(만들_수_있는_치킨);
