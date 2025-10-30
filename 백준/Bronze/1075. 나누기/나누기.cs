namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());

            int result = (n / 100) * 100;
            int num = 0;

            for (int i = 0; result % F != 0; i++)
            {
                result += 1;
                num += 1;
                if (result % F == 0)
                {
                    break;
                }
            }

            Console.WriteLine(num.ToString("D2"));
        }
    }
}
