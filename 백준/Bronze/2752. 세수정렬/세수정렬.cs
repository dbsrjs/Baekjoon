string[] str = Console.ReadLine().Split();

int a = int.Parse(str[0]);
int b = int.Parse(str[1]);
int c = int.Parse(str[2]);

int[] arr = {a, b, c };

Array.Sort(arr);

Console.WriteLine($"{arr[0]} {arr[1]} {arr[2]}");