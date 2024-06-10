int x = Int32.Parse(Console.ReadLine());
int y = Int32.Parse(Console.ReadLine());

/*
+ + : 1
- + : 2
- - : 3
+ - : 4
*/

if (x > 1 && y > 1)
    Console.WriteLine(1);
else if (x < 1 && y > 1)
    Console.WriteLine(2);
else if (x < 1 && y < 1)
    Console.WriteLine(3);
else if (x > 1 && y < 1)
    Console.WriteLine(4);