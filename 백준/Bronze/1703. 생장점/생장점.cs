 while (true)
 {
     string[] input = Console.ReadLine().Split();
     int len = int.Parse(input[0]);
     if (len == 0) break;

     int n = 1;
     for (int i = 0; i < len; i++)
     {
         int sf = int.Parse(input[2 * i + 1]);
         int p = int.Parse(input[2 * i + 2]);
         n = n * sf - p;
     }
     Console.WriteLine(n);
 }