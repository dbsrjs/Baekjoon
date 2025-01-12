string[] inputs = Console.ReadLine().Split();
        int A = int.Parse(inputs[0]);
        int B = int.Parse(inputs[1]);

        while (A >= 2)
        {
            if (B >= A - 1)
            {
                Console.WriteLine(2 * A - 1);
                break;
            }
            else
            {
                A -= 1;
            }
        }