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
            string [] input = Console.ReadLine().Split();
            int [] s = { 1, 1, 2, 2, 2, 8 };
            for (int i=0; i<input.Length; i++)
            {
                s[i] -= int.Parse(input[i]);
            }
            foreach (int j in s)
            {
                Console.Write(j.ToString() + " ");
            }
        }
    }
}