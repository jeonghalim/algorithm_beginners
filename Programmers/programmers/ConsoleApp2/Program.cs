using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int [] citations = new int[] { 3, 3, 6, 2, 5, 1, 2, 1,1,1,1,1 };

            Array.Sort(citations);              // 올림차순
            Array.Reverse(citations);           // 내림차순 {6,5,3,3,2,2,1,1}

            for (int i = 0; i < citations.Length; i++)
            {
                int a = citations[answer];  // 디버깅 용
                int b = answer + 1;         // 디버깅 용
                if (answer <= citations[i] && a >= b) //4 //3 // 중복잼
                    answer++;
            }

            Console.WriteLine("h-index: " + answer);
        }
    }
}
