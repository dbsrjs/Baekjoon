int N = int.Parse(Console.ReadLine());
        bool check = false;

        for (int i = 2; i < 10; i++)
        {
            if (!check) // check이 False일 때만 실행
            {
                for (int j = 1; j < 10; j++)
                {
                    if (N == i || N == j || N == i * j)
                    {
                        check = true;
                        break;
                    }
                }
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(check ? 1 : 0);