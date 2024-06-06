while (true)
        {
            string input = Console.ReadLine();
            if (input == null) break;
            string[] AB = input.Split();
            int a = int.Parse(AB[0]);
            int b = int.Parse(AB[1]);
            Console.WriteLine(a + b);
        }