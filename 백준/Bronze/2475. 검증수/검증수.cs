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
            int sum = 0;  // 변수 사용을 위해 반드시 초기화
            for (int i=0; i<input.Length; i++)
            {
                sum += (int)Math.Pow(int.Parse(input[i]), 2);
            }  // 데이터 형식 double -> int
            int result = sum % 10;
            Console.WriteLine(result);
        }
    }
}