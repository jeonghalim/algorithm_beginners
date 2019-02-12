using System;

namespace Application
{
    class MainClass
    {
        public class Node
        {

            public int data;
            public Node next;

            public Node(Node next, int data)
            {
                this.next = next;
                this.data = data;
            }

            public string Print()
            {
                if (next != null)
                {
                    return data.ToString() + next.Print();
                }
                else
                {
                    return data.ToString();
                }
            }
        }

        Node Div(Node list, int x)
        {
            Node head = null;
            Node tail = null;

            while (list != null)
            {
                Node newnext = list.next;
                if (list.data < x)
                {
                    list.next = head;
                    head = list;
                }
                else
                {
                    list.next = tail;
                    tail = list;
                }

                list = newnext;
            }

            Node finish = head;
            if (head == null)
            {
                return tail;
            }

            while (head.next != null)
            {
                head = head.next;
            }

            head.next = tail;

            return finish;

        }

        public static void Main(string[] args)
        {
            int[] data = { 1, 2, 5, 4, 3 };
            MainClass m = new MainClass();
            Node list = new Node(null, data[0]); // 초기화는 따로

            for (var i = 1; i < data.Length; i++)
            {
                list = new Node(list, data[i]);
            }

            Node a = m.Div(list, 5);

            Console.WriteLine(a.Print());
        }
    }
}
