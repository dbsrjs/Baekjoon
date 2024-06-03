string[] str = Console.ReadLine().Split();

int N = Int32.Parse(str[0]);

int X = Int32.Parse(str[1]);

int[] arrays = new int[N];

string[] arr = Console.ReadLine().Split();

for (int i = 0; i < arrays.Length; i++)
{
    arrays[i] = Int32.Parse(arr[i]);
}

for (int i = 0; i < arrays.Length; i++)
{
    if (arrays[i] < X)
        Console.Write(arrays[i] + " ");
}