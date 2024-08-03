string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);  //시 0 ~ 23          3600초
int b = int.Parse(str[1]);  //분 0 ~ 59          60초
int c = int.Parse(str[2]);  //초 0 ~ 59          

int hour, minute, second;

int d = int.Parse(Console.ReadLine());//요리를 하는데 필요한 시간(초 단위)

hour = (d / 3600) + a;
d %= 3600;

minute = (d / 60) + b;
d %= 60;

second = (d + c);

if (second > 59)
{
    second -= 60;
    minute++;
}

if (minute > 59)
{
    minute -= 60;
    hour++;
}

hour %= 24;

Console.WriteLine($"{hour} {minute} {second}");