using System;

int num = int.Parse(Console.ReadLine());

string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);
int d = int.Parse(str[3]);
int e = int.Parse(str[4]);

int cnt = 0;

if (a == num)
    cnt += 1;
if (b == num)
    cnt += 1;
if (c == num)
    cnt += 1;
if (d == num)
    cnt += 1;
if (e == num)
    cnt += 1;

Console.WriteLine(cnt);