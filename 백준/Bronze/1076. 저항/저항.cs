namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colorIndex = new Dictionary<string, int>()
            {
                {"black", 0},
                {"brown", 1},
                {"red", 2},
                {"orange", 3},
                {"yellow", 4},
                {"green", 5},
                {"blue", 6},
                {"violet", 7},
                {"grey", 8},
                {"white", 9},
            };

            string color1 = Console.ReadLine();
            string color2 = Console.ReadLine();
            string color3 = Console.ReadLine();

            int num = 0;

            int first = colorIndex[color1];
            int second = colorIndex[color2];
            int multiplier = colorIndex[color3];

            long result = (first * 10 + second) * (long)Math.Pow(10, multiplier);
            Console.WriteLine(result);
        }
    }
}