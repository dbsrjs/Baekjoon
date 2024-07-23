List<string> list = new List<string>()
        {
            "Never gonna give you up",
            "Never gonna let you down",
            "Never gonna run around and desert you",
            "Never gonna make you cry",
            "Never gonna say goodbye",
            "Never gonna tell a lie and hurt you",
            "Never gonna stop"
        };

        int cnt = 0;

        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            string str = Console.ReadLine();

            if (list.Contains(str))
                cnt++;
        }

        if (cnt == input)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");