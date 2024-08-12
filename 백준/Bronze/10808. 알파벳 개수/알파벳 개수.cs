using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int[] counts = new int[26]; // 알파벳 등장갯수를 저장 할 배열. a: 0, b: 1, ...의 규칙으로 인덱스를 매김.
            for(int i = 0; i < line.Length; i++)
            {
                int index = line[i] - 'a';
                counts[index]++;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 26; i++)
            {
                sb.Append(counts[i]);
                sb.Append(' ');
            }

            Console.WriteLine(sb);
        }
    }
}