using System;
using System.Collections;
using System.Text;

namespace algo
{
    class MainClass
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char front = input[i];
                char back = ' ';
                if (i != input.Length - 1)
                {
                    back = input[i + 1];
                }

                if (front == back)
                {
                    count++;
                }
                else
                {
                    count++;
                    sb.Append(input[i].ToString() + count.ToString()); // append: 문자열 뒤에 다른 문자열 추가
                    count = 0;
                }
            }
            if (sb.Length > input.Length)
                Console.WriteLine(input);
            else
                Console.WriteLine(sb);
        }
    }
}
