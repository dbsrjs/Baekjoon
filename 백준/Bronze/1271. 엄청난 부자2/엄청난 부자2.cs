using System;
using System.Numerics;

class Program {
    static void Main(string[] args) {
        string stringInput = Console.ReadLine();
        string[] arrayStrings = stringInput.Split(' ', StringSplitOptions.None);
        BigInteger N = BigInteger.Parse(arrayStrings[0]);
        BigInteger M = BigInteger.Parse(arrayStrings[1]);

        BigInteger divided = N / M;
        BigInteger remained = N % M;
        
        Console.WriteLine(divided);
        Console.WriteLine(remained);
    }
}
