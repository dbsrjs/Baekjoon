namespace Solution {
  class Program {
    static void Main(string[] args) {

      var str = Console.ReadLine()!;
      var idx = int.Parse(Console.ReadLine()!);

      Console.WriteLine(str[idx - 1]);

    }
  }
}