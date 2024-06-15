string str = Console.ReadLine();
int value = 0;

for(int i = 0; i< str.Length; i++)
{
   value = (value * 10 + (str[i] - '0')) % 20000303;
}

Console.WriteLine(value);   