using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    class Program
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
  

            public void Inorder(Node node) //중위 순회 테스트
            {
                if (node != null)
                {
                    Inorder(node.Left);
                    Console.Write(node.Data);
                    Inorder(node.Right);
                }
                else
                    return;
            }

            public bool checkBst(Node root)
            {
                Node prenode = null;
                Node curnode = root;
                Node temp = null;

                while (curnode != null)
                {
                    if (curnode.Left == null)
                    {
                        if (prenode != null && prenode.Data >= curnode.Data) // root 보다 오른쪽 노드가 같거나 작을 경우
                            return false;
                        prenode = curnode;
                        curnode = curnode.Right;
                    }

                    else
                    {
                        temp = curnode.Left;
                        while (temp.Right != null && temp.Right != curnode)
                            temp = temp.Right;

                        if (temp.Right == null)
                        {
                            temp.Right = curnode;
                            curnode = curnode.Left;
                        }

                        else
                        {
                            temp.Right = null;
                            if (prenode != null && prenode.Data >= curnode.Data) // 오른쪽 노드가 왼쪽보다 같거나 작을때
                                return false;

                            prenode = curnode;
                            curnode = curnode.Right;
                        }
                    }
                }
                return true;
            }

        }

        static void Main(string[] args)
        {
            Node node;
            node = new Node(1);
            node.Left = new Node(1);
            node.Right = new Node(2);
            //node.Right.Left = new Node(1);
            //node.Right.Right = new Node(11);

            node.Inorder(node);
            Console.WriteLine(node.checkBst(node));
        }
    }
}
