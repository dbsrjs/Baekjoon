namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] scores = Array.ConvertAll(input, int.Parse);
            
            Array.Sort(scores);

            Console.WriteLine(scores[1]);
        }
    }
}
