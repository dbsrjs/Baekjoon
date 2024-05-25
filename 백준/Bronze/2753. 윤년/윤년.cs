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
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine(year % 4 == 0 && year % 100 != 0 || year % 400 == 0 ? 1 : 0);
        }
    }
}