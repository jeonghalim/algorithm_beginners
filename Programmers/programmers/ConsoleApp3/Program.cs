using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.solution(8,4,7);
        }

        public int solution(int n, int a, int b)
        {
            int answer = 0;

            while (a != b)
            {
                a = a - a / 2;
                b = b - b / 2;
                answer++;
            }

            return answer;
        }

    }
}
