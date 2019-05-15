using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.solution(8, 1);
        }
        public int[] solution(int brown, int red)
        {
            int a; // 가로값
            int b; // 세로값
            int count = brown + red; // 전체 타일 개수
            int[] answer = new int[] { };

            List<int> divisor = new List<int>();

            for (int i = 1; i <= count; i++) // 약수 구하기
            {
                if ((count % i) == 0)
                {
                    divisor.Add(i);
                }
                    
            }

            for(int i=0; i<divisor.Count; i++)
            {
                b = divisor[i];
                for(int j= 0; j<divisor.Count;j++)
                { 
                    a = divisor[j];
                    
                    if(a+b == ((brown+4)*0.5) && a*b == count)
                    {
                        answer = new int[] { a, b };
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}
