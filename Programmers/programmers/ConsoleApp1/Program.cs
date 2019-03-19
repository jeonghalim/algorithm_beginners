using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "987654321";
            int k=3;                                // 제외될 자릿수
            string answer = "";

            Stack<char> stack = new Stack<char>();  //스택
            int answerLength = number.Length - k;      //answer 자릿수
            for (int i = 0; i < number.Length; i++)
            {
                char ch = number[i];

                for (; (stack.Count !=0) && k > 0; k--)
                {
                    char stack_top = stack.Peek();
                    if (stack_top >= ch)
                        break;                      //만약 스택 가장 위에있는 수보다 ch가 작거나 같으면 break

                    stack.Pop();                    //처리하고자 하는 수가 더 크다면 스택 가장 위에있는 수를 제거
                }

                stack.Push(ch);                      
            }

            while (stack.Count != answerLength)
                stack.Pop();



            while (stack.Count != 0)                //answer
            {
                char x = stack.Peek();
                answer = x + answer;
                stack.Pop();
            }
            Console.WriteLine(answer);
        }
    }
}
