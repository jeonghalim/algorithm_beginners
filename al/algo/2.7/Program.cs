using System;

namespace Application
{
    class MainClass
    {
        /*단방향 연결리스트 두 개가 주어졌을 때 이 두 리스트의 교집합 노드를 찾은 뒤 반환하는 코드를 작성하라. 
         * 여기서 교집합이란 노드의 값이 아니라 노드의 주소가 완전히 같은 경우를 말한다. 
         * 즉, 첫 번째 리스트에 있는 k 번째 노드와 두 번째 리스트에 있는 j 번째 노드가 *주소까지* *완전히* *같다면*  
         * 이 노드는 교집합의 원소가 된다.*/

        public class Node
        {
            public int data;
            public Node next;

            public Node(Node next, int data)
            {
                this.data = data;
                this.next = next;
            }
        }

        public void Intesection(Node node1, Node node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1.data == node2.data)
                {
                    if (node1.next.data != node2.next.data)
                    {
                        return;
                    }
                    Intesection(node1.next, node2.next);
                    Console.Write(node1.data);
                }

                node1 = node1.next;
                node2 = node2.next;
            }
            return;
        }

        public static void Main(string[] args)
        {
            MainClass m = new MainClass();
            int[] data = { 1, 2, 3, 4, 5 };
            int[] data2 = { 9, 0, 7, 8, 5 };

            Node list = new Node(null, data[0]); // 초기화는 따로
            Node list2 = new Node(null, data2[0]); // 초기화는 따로

            for (int i = 1; i < data.Length; i++)
            {
                list = new Node(list, data[i]);
                list2 = new Node(list2, data2[i]);
            }

            m.Intesection(list, list2);
        }
    }

}
