using System;

namespace Application
{
    /*기본적인 push와 pop 기능이 구현된 스택에서 최솟값을 반환하는 min함수를 추가하려고 한다. 
     * 어떻게 설계할 수 있겠는가? 
     * push, pop, min연산은 모두 O(1) 시간에 동작해야 한다.*/
    public class Node
    {
        public int data;
        public Node next;
    }

    public class Stack
    {
        Node top;
        Node minvalue;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newnode = new Node();
            newnode.data = data;

            if (isEmpty())
            {
                top = newnode;
                minvalue = newnode;

            }
            else
            {
                newnode.next = top;
                top = newnode;

                if (newnode.data <= minvalue.data)
                {
                    newnode.next = minvalue;
                    minvalue = newnode;
                }
            }
        }

        public int Pop()
        {
            if (isEmpty())
                return -1;
             
            int topvalue = top.data;

            if (minvalue.data == topvalue)
            {
                minvalue = minvalue.next;
            }

            top = top.next;
            return topvalue;
        }

        public int Min()
        {
            return minvalue.data;
        }

        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);


            Console.WriteLine(stack.Min());
        }
    }
}
