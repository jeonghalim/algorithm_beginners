using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Node
    {
        public int data;
        public Node left, right, nextRight;
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
            nextRight = null;
        }
        public int MaxDepth(Node node) // 오른쪽, 왼쪽중 깊이가 큰 곳 반환
        {
            if (node == null)
                return 0;

            return 1 + Math.Max(MaxDepth(node.left), MaxDepth(node.right)); //마지막 재귀 0반환 --> +1씩
        }
        public void Connect(Node root,int depth)
        {
            Queue<Node> queue = new Queue<Node>();
            List<List<int>> list = new List<List<int>>();
        
            int count = 0;
            Node peek = null;

            queue.Enqueue(root);
            queue.Enqueue(null);
            list.Add(new List<int>());
            while (queue.Count != 0)
            {
                peek = queue.Peek();
                queue.Dequeue();
                if (peek != null)
                {
                    peek.nextRight = queue.Peek();
                    list[count].Add(peek.data);
                    if (peek.left != null)
                        queue.Enqueue(peek.left);
                    if (peek.right != null)
                        queue.Enqueue(peek.right);
                }
                else if (queue.Count != 0)
                {
                    queue.Enqueue(null);
                    Console.Write(count +1 + "깊이 리스트 노드: ");
                    list[count].ForEach(x => { Console.Write(x); });

                    Console.WriteLine("\n");
                    count++;
                    list.Add(new List<int>());
                }
                else if (queue.Count == 0)
                {
                    Console.Write(count + 1 + "깊이 리스트 노드: ");
                    list[count].ForEach(x => { Console.Write(x); });
                    Console.WriteLine("\n");
                }
            }
        }
    }
    class Program
    {
       
        public static void Main()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            root.Connect(root, root.MaxDepth(root));
        }
    }
}  

