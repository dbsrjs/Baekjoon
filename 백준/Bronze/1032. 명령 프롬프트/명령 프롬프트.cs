int T = int.Parse(Console.ReadLine());
string[] arr = new string[T];

for (int i = 0; i < T; i++)
{
    arr[i] = Console.ReadLine();
}

string result = "";

for (int i = 0; i < arr[0].Length; i++)
{
    char firstChar = arr[0][i]; 

    bool isSame = true;
    for (int j = 1; j < T; j++)
    {
        if (arr[j][i] != firstChar)
        {
            isSame = false;
            result += "?";
            break;
        }
    }

    if (isSame)
        result += firstChar;
}

Console.WriteLine(result);