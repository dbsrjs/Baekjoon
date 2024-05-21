using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
                Console.WriteLine($"{N} * {i} = {N*i}");
        }
    }
}