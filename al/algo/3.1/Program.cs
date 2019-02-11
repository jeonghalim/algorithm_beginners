using System;

namespace Application
{
    public class Stack
    {
    
        int stacksize;
        int[] arr;
        int[] stackoftop;

        public Stack(int stacksize)
        {
            this.stacksize = stacksize;
            arr = new int[3 * stacksize]; // 3의 배수 사이즈의 배열
            stackoftop = new int[3]; // 각 스텍의 탑 포인트
        }

        public void Push(int num, int value)
        {
            if (IsFull(num))
                Console.WriteLine("넘침");
            else
            {
                 stackoftop[num]++;
                arr[Topvalue(num)] = value; // vaule = 배열값
            }
        }

        public int Pop(int num)
        {
            int popvalue;
            if (IsEmpty(num))
            {
                Console.WriteLine("텅빔");
                return -1;
            }

            else
            {
                popvalue = arr[Topvalue(num)];
                arr[Topvalue(num)] = 0;
                stackoftop[num]--;
                return popvalue;
            }
        }

        public int Top(int num)
        {
            if (IsEmpty(num))
            {
                Console.WriteLine("텅빔2");
                return -1;
            }
            else
                return arr[Topvalue(num)];
        }

        public bool IsEmpty(int num)
        {
            return (stackoftop[num] == 0);
        }
        public bool IsFull(int num)
        {
            return (stackoftop[num] == stacksize);
        }


        int Topvalue(int num)
        {
            int startIndex = num * stacksize;
            int top = stackoftop[num];
            return (startIndex + top - 1);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack(2); //사이즈 2

            stack.Push(0, 1);
            stack.Push(0, 2);
            //----------------------------------------------
            stack.Push(1, 3);
            stack.Push(1, 4);
            //----------------------------------------------
            stack.Push(2, 5);
            stack.Push(2, 6);

            Console.WriteLine(stack.Top(0));
            Console.WriteLine(stack.Top(1));
            //----------------------------------------------
            Console.WriteLine(stack.Pop(2));
            Console.WriteLine(stack.Pop(2));
        }
    }
}
