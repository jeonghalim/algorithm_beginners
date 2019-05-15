using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] plays = new int[] { 500, 600, 150, 800, 2600, 2100, 1000 };
            string[] genres = new string[] { "classic","pop" ,"classic", "classic", "pop", "zazz", "zazz" };
            p.solution(genres, plays);
        }
        public List<int> solution(string[] genres, int[] plays)
        {
            string[] uniqueArr = genres.Distinct().ToArray(); //genres 중복제거

            Dictionary<int, int> dicplay = new Dictionary<int, int>();
            Dictionary<int, string> dicgen = new Dictionary<int, string>();
            Dictionary<int, string[]>[] dictionary = new Dictionary<int, string[]>[uniqueArr.Length];
            Dictionary<int, int>[] a = new Dictionary<int, int>[dictionary.Length];
            List<int> sum = new List<int>();
            List<int> answer = new List<int>();

            for (int i = 0; i < plays.Length; i++)
            {
                dicplay.Add(i, plays[i]);
                dicgen.Add(i, genres[i]);
            }

            for (int i = 0; i < uniqueArr.Length; i++)
            {
                var key = dicgen.Where(x => x.Value == uniqueArr[i]); //genres에 맞는 키 추출  
                dictionary[i] = new Dictionary<int, string[]>();

                foreach (var pair in key)
                {                  
                    dictionary[i].Add(pair.Key, new string[] {pair.Value, dicplay[pair.Key].ToString()}); // [classic,500]
                }
            }

            for (int i = 0; i < dictionary.Length; i++)
            {              
                a[i] = new Dictionary<int, int>();
                foreach (var h in dictionary[i])
                {
                    a[i].Add(h.Key,int.Parse(h.Value[1])); // [0,500]                   
                }
                
                var b = a[i].OrderByDescending(num => num.Value);
                a[i] = new Dictionary<int, int>();

                foreach (var h in b)
                {
                    a[i].Add(h.Key, h.Value);
                }

                sum.Add(a[i].Values.Sum());
            }

            while (sum.Max() != 0)
            {
                
                int index = sum.IndexOf(sum.Max());
                sum[index] = 0;
                answer.Add(a[index].ElementAt(0).Key);

                if(a[index].Count>= 2)
                {
                    answer.Add(a[index].ElementAt(1).Key);
                }
            }

            return answer;
        }
    }
}
