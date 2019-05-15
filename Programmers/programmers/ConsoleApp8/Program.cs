using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int n = 4;
            int[] works = { 4,3,3 };
            p.solution2(n, works);
        }

        public long solution2(int n, int[] works)
        {
            long answer = 0;

            Array.Sort(works);

            for (int i = 0; i <= n - 1; i++)
            {
                int max = works.Length - 1;

                while (max > 0)
                {
                    if (works[max] > works[max-1])
                        break;

                    --max;
                }

                if (works[max] > 0)
                    works[max]--;
                else
                    break;
            }

            for(int i=0; i<works.Length; i++)
            {
                answer += (long)Math.Pow(works[i], 2);
            }
            Console.WriteLine(answer);
            return answer;


        }
    public long solution(int n, int[] works)
        {

            long answer = 0;
            List<int> list = new List<int>();
            
            for (int i = 0; i < works.Length; i++)
            {
                list.Add(works[i]);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int index = list.FindIndex(a => a == list.Max());
                list[index]--;
                if(list.Sum() ==0)
                {
                    Console.WriteLine(answer);
                    return answer;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                answer += (list[i] * list[i]);
            }

            Console.WriteLine(answer);
            return answer;

        }
    }
}
