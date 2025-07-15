using System;
using System.Numerics;

BigInteger num1 = BigInteger.Parse(Console.ReadLine());
string op = Console.ReadLine();
BigInteger num2 = BigInteger.Parse(Console.ReadLine());

if(op == "+")
{
    Console.WriteLine(num1 + num2);
}

else if(op == "*")
{
    Console.WriteLine(num1 * num2);
}