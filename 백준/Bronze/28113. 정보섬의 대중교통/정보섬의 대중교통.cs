using System;

string[] str = Console.ReadLine().Split();

int walk = int.Parse(str[0]); //지하철 역
int bus = int.Parse(str[1]); //버스
int lastTime = int.Parse(str[2]); //지하철
int subway = walk + (lastTime - walk);

Console.WriteLine(bus != subway ? (bus < subway ? "Bus" : "Subway") : "Anything");