using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }

        public bool IsBalanced(Node node) // 균형 확인
        {
            return (MaxDepth(node) - MinDepth(node) <= 1); // 깊이 차이가 1보다 클 경우 균형 x
        }

        public int MaxDepth(Node node) // 오른쪽, 왼쪽중 깊이가 큰 곳 반환
        {
            if (node == null)
                return 0;

            return 1 + Math.Max(MaxDepth(node.Left), MaxDepth(node.Right)); //마지막 재귀 0반환 --> +1씩
        }

        public int MinDepth(Node node) // 오른쪽, 왼쪽중 깊이가 작은곳 반환 
        {
            if (node == null)
                return 0;

            return 1 + Math.Min(MinDepth(node.Left), MinDepth(node.Right)); //마지막 재귀 0반환 --> +1씩
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node node;
            node = new Node(1);                                         //       1
            node.Left = new Node(2);                                    //     2   3 
            node.Right = new Node(3);                                   //   4
            node.Left.Left = new Node(4);                               // 5   
            node.Left.Left.Left = new Node(5);
            Console.WriteLine(node.IsBalanced(node)); //false

            Node node2;
            node2 = new Node(1);                                         //         1
            node2.Left = new Node(2);                                    //     2       3 
            node2.Right = new Node(3);                                   //   4   5   6   7
            node2.Left.Left = new Node(4);                               //    
            node2.Left.Right = new Node(5);
            node2.Right.Left = new Node(6);
            node2.Right.Right = new Node(7);
            Console.WriteLine(node2.IsBalanced(node2)); //true

        }
    }
}
