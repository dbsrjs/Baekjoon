using System;

int[] pro = { 12, 11, 11, 10, 9, 9, 9, 8, 7, 6, 6 };
int[] pan = {1600, 894, 1327, 1311, 1004, 1178, 1357, 837, 1055, 556, 773};

int N = int.Parse(Console.ReadLine());

Console.Write(pro[N - 1]);
Console.Write(" " + pan[N - 1]);