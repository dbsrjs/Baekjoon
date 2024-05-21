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
            // 시간 초과
            //string s = Console.ReadLine();
            //int n = int.Parse(s);
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int n = int.Parse(Console.ReadLine());
            StringBuilder allNum = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                allNum.AppendLine(i.ToString());
            }

            Console.WriteLine(allNum);
        }
    }
}