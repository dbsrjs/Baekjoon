string[] input = Console.ReadLine().Split();
int lv = int.Parse(input[0]);
string sign = input[1];

if (sign == "miss")
    Console.WriteLine(0);
else if (sign == "bad")
    Console.WriteLine(200 * lv);
else if (sign == "cool")
    Console.WriteLine(400 * lv);
else if (sign == "great")
    Console.WriteLine(600 * lv);
else if (sign == "perfect")
    Console.WriteLine(1000 * lv);