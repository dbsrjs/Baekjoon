 for (int i = 0; i < 3; i++)
 {
     string[] input = Console.ReadLine().Split();
     int zeroCount = 0;

     foreach (string s in input)
     {
         if (s == "0") zeroCount++;
     }

     switch (zeroCount)
     {
         case 1:
             Console.WriteLine("A");
             break;
         case 2:
             Console.WriteLine("B");
             break;
         case 3:
             Console.WriteLine("C");
             break;
         case 4:
             Console.WriteLine("D");
             break;
         default:
             Console.WriteLine("E");
             break;
     }
 }