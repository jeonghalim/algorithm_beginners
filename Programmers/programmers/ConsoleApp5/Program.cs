using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] times = new int[] {10,1,1 };
            p.solution2(5,times);
        }
        public long solution(int n, int[] times)
        {
            int t = 0;
            long answer = 0;
            int count = 0;
            int minute = 0;
            int[] a = new int[times.Length - 1];
            Array.Sort(times);
            count = (int)(n * 0.5); //반으로 줄이기

            while (count + t <= n)
            {
                minute = times[0] * count; // ex) 7*3 // 최소분에 최대한 가깝게
                for (int i = 1; i < times.Length; i++)
                {
                    double c = minute / times[i];
                    int x = (int)System.Math.Truncate(c);

                    if (x == a[i-1])
                    {
                        break;
                    }

                    a[i-1] = (int)System.Math.Truncate(c);
                    t += (int)System.Math.Truncate(c);
                }
                count++;
            }

            answer = minute;
            Console.WriteLine(answer);
            return answer;
        }

        public ulong solution2(int n, int[] times)
        {

            ulong answer = 0;
            ulong[] a = new ulong[times.Length];
            ulong Max = (ulong)(n * times.Length-1); //최악;; 6 -> 60분

            ulong Min = 0ul;

            while (Min <= Max)
            {
                ulong mid = (Min + Max) / 2;
                ulong x = 0;
                for (int i = 0; i < times.Length; i++)
                {
                    a[i] = (ulong)(mid / (ulong)times[i]);
                    x += a[i];
                }

                if ((ulong)n <= x)
                {
                    Max = mid - 1;
                    answer = mid;
                }

                if ((ulong)n > x)
                {
                    Min = mid + 1;
                }
            }
            Console.WriteLine(answer);
            return answer;
        }

    }
}
