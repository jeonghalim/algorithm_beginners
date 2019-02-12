using System;

namespace Application
{
    public class Stack
    {
    
        int stacksize;
        int[] stackarr;
        int[] stackoftop;

        public Stack(int stacksize)
        {
            this.stacksize = stacksize;
            stackarr = new int[3 * stacksize]; 
            stackoftop = new int[3];
        }

        public void Push(int num, int value)
        {
            if (IsFull(num))
                Console.WriteLine("넘침");
            else
            {
                stackoftop[num]++;
                stackarr[Topvalue(num)] = value;
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
                popvalue = stackarr[Topvalue(num)];
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
                return stackarr[Topvalue(num)];
        }

        int Topvalue(int num)
        {
            int start = num * stacksize;
            int top = stackoftop[num];
            return (start + top - 1);
        }

        bool IsEmpty(int num)
        {
            return (stackoftop[num] == 0);
        }
        bool IsFull(int num)
        {
            return (stackoftop[num] == stacksize);
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
