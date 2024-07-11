using System;

string[] str = Console.ReadLine().Split();

int N = int.Parse(str[0]);
int M = int.Parse(str[1]);

Console.WriteLine(((N * 100) >= M) ? "Yes" : "No");